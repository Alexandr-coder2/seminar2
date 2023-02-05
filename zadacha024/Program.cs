// Задача на лекции 3 Дан текст надо поменять буквы к и с с больших
// на маленькие.


Console.Clear();

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие русского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}"; 
    }

    return result;
}

string newText = Replace(text, " ", "|");
Console.WriteLine(newText);


