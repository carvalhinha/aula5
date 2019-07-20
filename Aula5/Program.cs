using System;
using System.IO;
using System.Net;
using System.Collections.Generic;


namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {          
            List<CEP> cEPs = new List<CEP>();
            //Console.Write("Digite a quantidade de cep por pagina: ");
            //string totalPagina = Console.ReadLine().ToString();
            
            new CEP() {cep = "88305510" };
            new CEP() {cep = "45607005" };
            new CEP() {cep = "58803680" };
            new CEP() {cep = "76829106" };
            new CEP() {cep = "60831071" };
            new CEP() {cep = "74491205" };
            new CEP() {cep = "69312418" };
            new CEP() {cep = "84036170" };
            new CEP() {cep = "65099010" };
            new CEP() {cep = "76820672" };
            new CEP() {cep = "59157333" };
            new CEP() {cep = "79011330" };
            new CEP() {cep = "88350688" };
            new CEP() {cep = "76820306" };
            new CEP() {cep = "76964118" };
            new CEP() {cep = "27275470" };
            new CEP() {cep = "69303190" };
            new CEP() {cep = "74491566" };
            new CEP() {cep = "79816047" };
            new CEP() {cep = "69152063" };
            new CEP() {cep = "77062048" };
            new CEP() {cep = "50791420" };
            new CEP() {cep = "29155120" };
            new CEP() {cep = "29197655" };
            new CEP() {cep = "91540286" };
            new CEP() {cep = "69305510" };
            new CEP() {cep = "49089395" };
            new CEP() {cep = "55602640" };
            new CEP() {cep = "74486490" };
            new CEP() {cep = "29162480" };
            new CEP() {cep = "78065775" };
            new CEP() {cep = "65062500" };
            new CEP() {cep = "64028635" };
            new CEP() {cep = "77063254" };
            new CEP() {cep = "65067320" };
            new CEP() {cep = "25025380" };
            new CEP() {cep = "54240320" };
            new CEP() {cep = "79091531" };
            new CEP() {cep = "68908821" };
            new CEP() {cep = "27320580" };
            new CEP() {cep = "49044316" };
            new CEP() {cep = "69303270" };
            new CEP() {cep = "59618680" };
            new CEP() {cep = "35162434" };
            new CEP() {cep = "22753756" };
            new CEP() {cep = "78148210" };
            new CEP() {cep = "65602140" };
            new CEP() {cep = "29195915" };
            new CEP() {cep = "06542120" };
            new CEP() {cep = "23535490" };

            foreach(CEP c in cEPs)
            {
                Console.Write("digite um cep da lista: ");
                WebRequest request = WebRequest.Create($"https://viacep.com.br/ws/c/json/");

                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    Console.WriteLine(responseFromServer);
                }
                response.Close();
            }        
        }
    }
}
