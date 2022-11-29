class Program{
static void Main (string[] args){
int resultat;
string s = Console.ReadLine();
if(!int.TryParse(Console.ReadLine(), out resultat))
Console.WriteLine("skriv in en siffra");

}
 static bool TryParse(string s, out int result){
         if (int.TryParse(s, out result))
         {
            return true;
         }
         return false;
        }
}

