using System;

namespace CodeProblems;

public class PrimeNumber
{
    internal static bool IsPrime(int number)
    {
        //number less than 2 including -ve are not prime
        if (number < 2)
            return false;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }


    internal static bool IsPrime2(int number)
    {
        //Numbers less than 2 are not prime.
        if (number < 2)
            return false;

        //2 is the only even prime number.
        if (number == 2)
            return true;

        //If the number is divisible by 2, it is even.
        //All even numbers greater than 2 are not prime.
        if (number % 2 == 0)
            return false;

        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}


/*
i * i म्हणजे फक्त i चा square.

i * i = i square
उदा.

3 * 3 = 9
5 * 5 = 25
7 * 7 = 49
Code मध्ये हे आहे:

for (int i = 3; i * i <= number; i += 2)
याचा अर्थ:

जोपर्यंत i चा square number पेक्षा लहान किंवा equal आहे,
तोपर्यंत loop चालू ठेव.
उदा. number = 45

i = 3
3 * 3 = 9
9 <= 45 yes, check 3

i = 5
5 * 5 = 25
25 <= 45 yes, check 5

i = 7
7 * 7 = 49
49 <= 45 no, stop
म्हणजे आपण 45 साठी फक्त 3 आणि 5 check करतो. 7 check करत नाही.

का?

कारण 7 * 7 = 49, आणि 49 हे 45 पेक्षा मोठे आहे.

म्हणजे 7 पेक्षा मोठे दोन्ही factors मिळून 45 बनवू शकत नाहीत.

चला एकदम सोप्या भाषेत:

जर 45 ला काही factor असेल, तर एक factor छोटा आणि एक factor मोठा असतो:

1 x 45
3 x 15
5 x 9
इथे छोटे factors:

1, 3, 5
मोठे factors:

45, 15, 9
आपण फक्त छोटे factors check केले तरी पुरेसे आहे.

i * i <= number हे code ला सांगते:

छोट्या side पर्यंतच जा.
45 मध्ये:

5 x 9 = 45
यानंतर 7 x 7 = 49, म्हणजे middle cross झाला.

म्हणून stop.

एक लक्षात ठेवण्यासारखी line:

जेव्हा i * i number पेक्षा मोठे होते,
तेव्हा आपण square root च्या पुढे गेलो असतो.
म्हणून:

i * i <= number
हे square root काढण्याशिवाय square root पर्यंत loop चालवायचा shortcut आहे.
*/
