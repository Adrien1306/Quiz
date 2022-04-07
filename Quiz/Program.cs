namespace quiz;

class Program
{
    static void Main()
    {
        int NumberCorrectAnswer = 0;

        Test Test1 = new();
        Test1.IdTest = 1;
        Test1.Question = "Ici la question 1";
        Test1.Answer1 = "Ici la réponse 1 à question 1";
        Test1.Answer2 = "Ici la réponse 2 à question 1";
        Test1.Answer3 = "Ici la réponse 3 à question 1";
        Test1.Answer4 = "Ici la réponse 4 à question 1";
        Test1.IdRightAnswer = 1;
        Test1.DisplayTest();
        int ChosenAnswer = Int32.Parse(Console.ReadLine());
        if (ChosenAnswer == Test1.IdRightAnswer)
        {   
            Console.WriteLine("Nonbre de bonnes réponses : {0}", ++NumberCorrectAnswer);
        }
        else
        {
            Console.WriteLine("Ceci n'est pas la bonne réponse");
        }

        Test Test2 = new();
        Test2.IdTest = 2;
        Test2.Question = "Ici la question 2";
        Test2.Answer1 = "Ici la réponse 1 à question 1";
        Test2.Answer2 = "Ici la réponse 2 à question 1";
        Test2.Answer3 = "Ici la réponse 3 à question 1";
        Test2.Answer4 = "Ici la réponse 4 à question 1";
        Test2.IdRightAnswer = 2;
        Test2.DisplayTest();
        int ChosenAnswer2 = Int32.Parse(Console.ReadLine());
        if (ChosenAnswer2 == Test2.IdRightAnswer)
        {
            Console.WriteLine("Nonbre de bonnes réponses : {0}", ++NumberCorrectAnswer);
        }
        else
        {
            Console.WriteLine("Ceci n'est pas la bonne réponse");
        }

    }

   
}

class Test
{
    public int IdTest { get; set; }
    public string? Question { get; set; }
    public string? Answer1 { get; set; }
    public string? Answer2 { get; set; }
    public string? Answer3 { get; set; }

    public string? Answer4 { get; set; }

    public int IdRightAnswer { get; set; }

    public void DisplayTest()
    {
        Console.WriteLine("TEST N°" + IdTest);
        Console.WriteLine("");
        Console.WriteLine(Question);
        Console.WriteLine("");
        Console.WriteLine("1- " + Answer1);
        Console.WriteLine("2- " + Answer2);
        Console.WriteLine("3- " + Answer3);
        Console.WriteLine("4- " + Answer4);
        Console.WriteLine("");
        Console.WriteLine("Tapez le numéro de la bonne réponse :");
    }

}
