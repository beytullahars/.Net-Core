// See https://aka.ms/new-console-template for more information

//  class Program{

//  }
// class Person
// {
// // public string isim;

//     // public int yas;

//     // public void bilgiAl(){

//     //     Console.WriteLine("isim : " + this.isim);
//     //     Console.WriteLine("Yaş : " + this.yas);

//     // }
// }
// class Araba{
// public string Marka { get; set; }
// public string Model { get; set; }
// public string Renk { get; set; }
// public bool Otomatik { get; set; }

// public void Start(){
//     Console.WriteLine(this.Marka + " " + this.Model + " çalıştırıldı.");
// }

// public void Stop(){
//     Console.WriteLine(this.Marka + " " + this.Model + " stop edildi");
// }
// public void Yavasla(){
//     Console.WriteLine(this.Marka + " " + this.Model + " yavaşlıyor");
// }
// public void Hızlan(){
//     Console.WriteLine(this.Marka + " " + this.Model + " hızlanıyor");
// }

// public void Menu(){
//     string komut="";
//     do
//     {
//             Console.WriteLine("1:Start\t 2:Stop\t 3:Yavaşla\t 4:Hızlan\t Çıkış:Ç ");
//             Console.Write("Seçiminiz : ");
//              komut=Console.ReadLine();

//              switch (komut)
//              {
//                 case "1" :
//                 this.Start();
//                 break;
//                 case "2" :
//                 this.Stop();
//                 break;
//                 case "3" :
//                 this.Yavasla();
//                 break;
//                 case "4" :
//                 this.Hızlan();
//                 break;
//                 default:
//                 Console.WriteLine("Uygulamadan çıkıldı. ");
//                 break;
//              }
//     } while (komut!="Ç");

// }

class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
    }

    class Product
    {
        public Product()
        {
            this.ProductId = (new Random()).Next(11111,99999);
            this.Comments = new Comment[3];
        }

        public Product(int productId):this()
        {
            this.ProductId = productId;
        }

        public Product(int productId,string name,double price,bool isApproved):this(productId)
        {
            this.Name = name;
            this.Price=price;
            this.IsApproved=isApproved;
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsApproved { get; set; }
        public Comment[] Comments { get; set; }
    



    static void Main(string[] args)
    {
        var c1 = new Comment { CommentId=1,Text="Güzel telefon"};

            var p1 = new Product();

            p1.Comments[0] = c1;

            Console.WriteLine(p1.ProductId);            
            Console.WriteLine(p1.Name);            
            Console.WriteLine(p1.Price);            
            Console.WriteLine(p1.IsApproved);         
            Console.WriteLine(p1.Comments[0].Text);         

            Console.WriteLine("*********************");

            var p2 = new Product(1213);

            p2.Comments[0] = c1;

            Console.WriteLine(p2.ProductId);            
            Console.WriteLine(p2.Name);            
            Console.WriteLine(p2.Price);            
            Console.WriteLine(p2.IsApproved); 
            Console.WriteLine(p2.Comments[0].Text);       

            Console.WriteLine("*********************");
            
            var p3 = new Product(1231,"samsung s7",3000,true);

            Console.WriteLine(p3.ProductId);            
            Console.WriteLine(p3.Name);            
            Console.WriteLine(p3.Price);            
            Console.WriteLine(p3.IsApproved);   

            p3.Comments[0] = c1;
            Console.WriteLine(p3.Comments[0].Text);  

        }
    }


        // var araba=new Araba();
        // araba.Marka="Mercedes";
        // araba.Model="ML-350";
        // araba.Renk="Siyah";
        // araba.Otomatik=true;

        // araba.Menu();



        //  Person p1=new Person();
        // p1.isim="hümeyra";
        // p1.yas=14;

        //  Person p2=new Person();
        //   p2.isim="belinay";
        // p2.yas=13;
        // p1.bilgiAl();
        // p2.bilgiAl();

    

    