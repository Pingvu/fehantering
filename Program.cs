class Program{
static void Main (string[] args){
int resultat;
if(!int.TryParse(Console.ReadLine(), out resultat))
Console.WriteLine("skriv in en siffra");
}
 static bool TryParse(string s, out int result){
    
         try
         {
            result= Convert.ToInt32(s);
            return true;
         }
         catch (System.Exception)
         { 
            throw;
         }
 }
 
}

