using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace hometaskMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Istifadeci adini daxil edin");
            string Name = "";
            string Surname = "";
            string FIN = "";
            string fatherName = "";
            string position = "";
            int salary = 0;
            string phoneNumber = "";

            Console.WriteLine("Ad daxil edin");
            while (true)
            {
                Console.WriteLine("Ilk herf boyuk,qalanlari kicik yazilmalidir.Soyad 2 den boyuk 20 den kicik olmalidir!!");
                Name = Console.ReadLine();
                if (Name.Length < 2 || Name.Length > 20)
                {
                    Console.WriteLine("Ad 2 den boyuk 20 den kicik olmalidi");
                }
                if(!char.IsUpper(Name[0]))
                {
                    Console.WriteLine("Ilk herf boyuk olmalidir");
                       continue;
                }
                else
                {
                    bool k=true;
                    for (int i = 1; i < Name.Length; i++)
                    {
                        if (!char.IsLetter(Name[i]))
                        {
                            k = false;
                            break;
                        }
                        if(!char.IsLower(Name[i]))
                        {
                            k = false;
                            break;  
                        }
                        if (k)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                Console.WriteLine("Soyadi daxil edin");
                while(true)
                {
                    Console.WriteLine("Ilk herfi boyuk qalanlari kicik olmalidir.Soyad 2 den boyuk 35 den kicik olmalidir.Daxilinde reqemden istifade olunmamalidir!!");
                    Surname=Console.ReadLine();
                    if (Surname.Length < 2 || Surname.Length > 35) 
                    {
                        Console.WriteLine("Soyad 2 den kicik 35 den boyuk olmamalidir");
                    }
                    if(!char.IsUpper(Surname[0]))
                    {
                        Console.WriteLine("ilk herf boyuk olmalidir");
                        continue;
                    }
                    else
                    {
                        bool k=true;
                        for(int i = 1;i < Surname.Length; i++)
                        {
                            if (!char.IsLetter(Surname[i]))
                            {
                                k = false;
                                break;
                            }
                            if(!char.IsLower(Surname[i]))
                            {
                                k = false;
                                break;
                            }

                        }
                        if (k)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                Console.WriteLine("Ata adini daxil edin");
                while (true)
                {
                    Console.WriteLine("Ilk herf boyuk qalanlari kicik olmalidir.Soyad 2 den boyuk 20 den kicik olmalidir.Daxilinde reqem olmamala");
                    fatherName = Console.ReadLine();
                    if (fatherName.Length < 2 || fatherName.Length > 20)
                    {
                        Console.WriteLine("Ata adi 2 den boyuk 20 den kicik olmalidir");
                    }
                    if(!char.IsUpper(fatherName[0]))
                    {
                        Console.WriteLine("Ilk herf boyuk olmalidir");
                        continue;

                    }
                    else
                    {
                        bool k = true;
                        for(int i = 1;  i < fatherName.Length; i++)
                        {
                            if (!char.IsLetter(fatherName[i]))
                            {
                                k = false;
                                break;
                            }
                            if (!char.IsLower(fatherName[i]))
                            {
                                k = false;
                                break;
                            }
                        }
                        if (k)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                while (true) 
                {
                    finintroduction();
                    Console.WriteLine("FIN daxil edin");
                    FIN = Console.ReadLine();
                    if (FIN.Length < 6 || FIN.Length > 8)
                    {
                        continue ;
                    }
                    bool k=true;
                    for(int i = 0; i < FIN.Length; i++)
                    {
                        if (!char.IsUpper(FIN[i]) && char.IsLetter(FIN[i]))
                        {
                            k = false;
                            break;
                        }
                        if(k)
                        {
                            break;
                        }
                        else
                        {
                            continue;

                        }

                    }
                    int Age = 0;

                    while (true)
                    {
                        Console.WriteLine("Yasinizi daxil edin :");
                        string input=Console.ReadLine();
                        


                        if(!int.TryParse(input, out Age))
                        {
                            Console.WriteLine("Herf daxil etmeyin");
                            continue;
                        }
                        if (Age < 18 || Age > 65)
                        {
                            Console.WriteLine("Yas 18-65 arasinda olmalidir");
                            continue;
                        }
                        break;
                    }
                    while (true)
                    {
                        Console.WriteLine("Islediyiniz saheni girin (HR,Audit<Engineer)");
                        position = Console.ReadLine();
                        if(position == "HR" || position == "Audit" || position == "Engineer")
                        {
                            break ;
                        }
                        else
                        {
                            Console.WriteLine("Asagadaki sahelerden birini girin");
                            continue;
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Maas miqdarini daxil edin.Maas miqdari 1500-5000 arasinda olmalidir,maas miqdarini herflerle daxil etmeyin!!");
                        string input = Console.ReadLine();

                        if (!int.TryParse(input,out salary))
                        {
                            Console.WriteLine("Herf daxil etmeyin");
                            continue;
                        }
                        if (salary >= 1500 || salary <= 5000)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Asagadaki maas araliqlarindan birini daxil edin");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Nomrenizi daxil edin.(+994 ile baslamalidir,wmumi uzunlugu 13 beraber olmalidir)");
                        phoneNumber = Console.ReadLine();
                        if (phoneNumber.Length==13 && phoneNumber[0] == '+' && phoneNumber[1]=='9'&&phoneNumber[2]=='9' && phoneNumber[3]=='4')
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Reqemleri duzgun daxil edin,asagadaki sertlere uygun telefon nomresi daxil edin");
                        }
                    }

                    Console.Write($"Adi : {Name} Soyad :{Surname} Ata adi : {fatherName} Fin kodu : {FIN} Yasi : {Age} Position : {position} Maas {salary} Telefon : {phoneNumber}");
                    Console.WriteLine("Siteme elave olundu");
                }
               
                

            }






        }
    }
}
