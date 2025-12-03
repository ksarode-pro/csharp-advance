/*

//exmaple of pulling queue messeged using Async, and processing them using multithreading 


public class VoucherWorker : BackgroundService
{
    private readonly BlockingCollection<CloudQueueMessage> _buffer =
        new BlockingCollection<CloudQueueMessage>(boundedCapacity: 200);  // controls backpressure

    private readonly CloudQueue _queue;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ILogger<VoucherWorker> _logger;

    public VoucherWorker(
        CloudQueue queue,
        IHttpClientFactory httpClientFactory,
        ILogger<VoucherWorker> logger)
    {
        _queue = queue;
        _httpClientFactory = httpClientFactory;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Start consumer threads
        var consumerTask = Task.Run(() => StartConsumers(stoppingToken), stoppingToken);

        // Producer loop: pull from Azure Queue and add to buffer
        while (!stoppingToken.IsCancellationRequested)
        {
            var messages = await _queue.GetMessagesAsync(
                messageCount: 16,
                visibilityTimeout: TimeSpan.FromMinutes(2),
                options: null,
                operationContext: null,
                cancellationToken: stoppingToken);

            if (!messages.Any())
            {
                await Task.Delay(1000, stoppingToken);
                continue;
            }

            foreach (var msg in messages)
            {
                // Will block if buffer full
                _buffer.Add(msg, stoppingToken);
            }
        }

        // End
        _buffer.CompleteAdding();
        await consumerTask;
    }

private Task StartConsumers(CancellationToken token)
{
    return Parallel.ForEachAsync(
        _buffer.GetConsumingEnumerable(token),
        new ParallelOptions
        {
            MaxDegreeOfParallelism = 50,
            CancellationToken = token
        },
        async (message, ct) =>
        {
            await ProcessMessage(message, ct);
        });
}


    private async Task ProcessMessage(CloudQueueMessage message, CancellationToken ct)
    {
        try
        {
            var client = _httpClientFactory.CreateClient("voucherApi");
            var model = Deserialize(message.AsString);

            var resp = await client.PostAsJsonAsync("/issue", model, ct);

            if (resp.IsSuccessStatusCode)
            {
                await _queue.DeleteMessageAsync(message, ct);
            }
            else
            {
                // extend visibility or let it return for retry
                _logger.LogError("Failed {Id} - {Status}", message.Id, resp.StatusCode);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing message {Id}", message.Id);
        }
    }
}

*/