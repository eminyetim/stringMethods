using System;


namespace string_hazirMetotlar
{
    class program
    {
        public static void Main(string[] args)
        {
            string str  = "Dersimiz CSharp, Hoşgeldiniz!";
            string str2 = "Hoşgeldiniz!";

            System.Console.WriteLine(str.Length);

            System.Console.WriteLine(str.ToUpper());
            System.Console.WriteLine(str.ToLower());

            System.Console.WriteLine(String.Concat(str," Yetim"));
            

           // Console.WriteLine(str.CompareTo(str2));
            System.Console.WriteLine(String.Compare(str,str2,true));//True büyük küçük harf kıyası yapar.
            System.Console.WriteLine(String.Compare(str,str2,false));


            System.Console.WriteLine("Contains :"+str.Contains(str2));
            System.Console.WriteLine(str.EndsWith("Hoşgeldiniz!"));
            System.Console.WriteLine(str.StartsWith("Merhaba"));

            System.Console.WriteLine(str.IndexOf("CS"));

            System.Console.WriteLine(str.Insert(0,"Merhaba, "));
            System.Console.WriteLine(str.LastIndexOf("!"));


            System.Console.WriteLine(str2.PadRight(30,'*'));
            System.Console.WriteLine(str2.PadLeft(30,'*'));

            System.Console.WriteLine(str2.Remove(0,1));
            System.Console.WriteLine(str.Remove(13));

            System.Console.WriteLine(str.Replace("CSharp","C#"));


            System.Console.WriteLine(str.Split(' ')[1]);//Boşluklara göre parçalayıp , parçaları diziye artar.

            System.Console.WriteLine(str.Substring(4));
            System.Console.WriteLine(str.Substring(4,4));

            


        }
    }
}