//using System.IO.Pipes;
//using System.Net.Security;
//using System.Reflection.Metadata;
//using System.Security.Cryptography.X509Certificates;

//namespace personalProject2401
//{
//    public class Item
//    {
//        public string itemName { get; set; }
//        public string itemDesc { get; set; }
//        public string itemPrice { get; set; }
//        public int itemAtk { get; set; }
//        public int itemDef { get; set; }
//        public int itemHP { get; set; }
//    }

//    public class LongSword : Item
//    {
//        public void StatusMSG()
//        {
//            Console.WriteLine("공격력+120");
//        }
//        public void StatusUp()
//        {
           
//        }
//    }
//    static internal class Program
//    {
        
//       static string[] myitems = {"단검"};
//       static string[] unequipedItem = {"단검" };

//       static int Level = 1;
//       static string Name = "까냥꾼";
//       static string Job = "전사";
//       static int Atk = 10;
//       static int Def = 5;
//       static int Health = 100;
//       static int Gold = 1500;

      
//        static void Main()
//        { 
//            Console.WriteLine("시작마을에 오신 것을 환영합니다!");
//            Console.WriteLine("던전에 가기 전 무엇을 준비할까요?");
//            Console.WriteLine();
//            Console.WriteLine("1. 상태 보기");
//            Console.WriteLine("2. 인벤토리");
//            Console.WriteLine("3. 상점");
//            Console.WriteLine();
//            Console.WriteLine("원하시는 행동을 입력해주세요.");

//            int answer = int.Parse(Console.ReadLine());

//            switch (answer)
//            {
//                case 1:
//                    Console.WriteLine("상태를 봅니다.");
//                    status();
//                    break;
//                case 2:
//                    Console.WriteLine("인벤토리를 봅니다.");
//                    inventory();
//                    break;
//                case 3:
//                    Console.WriteLine("상점으로 갑니다.");
//                    shop();
//                    break;
//                default:
//                    Console.WriteLine("잘못된 입력입니다.");
//                    break;
//            }
//        }
        

//        static void status()
//        {

//            Console.WriteLine("상태 보기");
//            Console.WriteLine("캐릭터의 상태가 표시됩니다.");
//            Console.WriteLine();
//            Console.WriteLine("Lv. " + Level);
//            Console.WriteLine(Name + "("+Job+")");
//            Console.WriteLine("공격력 : " + Atk);
//            Console.WriteLine("방어력 : "+ Def);
//            Console.WriteLine("체  력 : "+  Health);
//            Console.WriteLine("Gold"+Gold);
//            Console.WriteLine();
//            Console.WriteLine("0. 나가기");
//            Console.WriteLine();
//            Console.WriteLine("원하시는 행동을 입력해주세요.");

//            int answer =int.Parse(Console.ReadLine());

//            while (answer == 0)
//            {
//                if (answer == 0)
//                {
//                    Console.WriteLine("처음으로 돌아갑니다.");
//                    Console.WriteLine();
//                    Main();
//                }
//                else
//                {
//                    Console.WriteLine("잘못된 입력입니다.");
//                    answer =int.Parse(Console.ReadLine());
//                }
//            }
//        }
//        static void inventory()
//        {
//            Console.WriteLine("인벤토리");
//            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
//            Console.WriteLine();
//            Console.WriteLine("[아이템 목록]");
//            itemList();
//            Console.WriteLine();
//            Console.WriteLine("1. 장착 관리");
//            Console.WriteLine("0. 나가기");
//            Console.WriteLine("원하시는 행동을 입력해주세요.");

//            bool haveItem;
//            int answer = int.Parse(Console.ReadLine());
            

//            int currentItem = myitems.Length;

//            if (currentItem >= 1)
//            {
//                haveItem = true;
//            }
//            else
//            {
//                haveItem = false;
//            }

//            while (true)
//            {
//                if (answer == 0)
//                {
//                    Console.WriteLine("처음으로 돌아갑니다.");
//                    Console.WriteLine();
//                    Main();
//                    break;
//                }
//                if (answer == 1)
//                {
//                    if (!haveItem)
//                    {
//                        Console.WriteLine("아이템이 없습니다.");
//                        answer = int.Parse(Console.ReadLine());
                        
//                    }
//                    else
//                    {
//                        Console.WriteLine("장비 장착을 관리합니다.");
//                        Console.WriteLine();
//                        equipment();
//                        break;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("잘못된 입력입니다.");
//                    answer = int.Parse(Console.ReadLine());
//                }
//            }

//        }
//        static void equipment()
//        {
            
//            Console.WriteLine("인벤토리 - 장착 관리");
//            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
//            Console.WriteLine();
//            Console.WriteLine("[아이템 목록]");
//            itemList();
//            Console.WriteLine("장착/해제하고 싶은 아이템의 번호를 입력해주세요.");
//            int answer = int.Parse(Console.ReadLine());

//           while(true)
//            {

//                if (answer == 0)
//                {
//                    Console.WriteLine("처음으로 돌아갑니다.");
//                    Main();
//                    break;
//                }
//                if (answer >= 1 && answer <= 8)
//                {
//                    switch (answer)
//                    {
//                        case 1:
//                            break;
//                        case 2:
//                            break;
//                        case 3:
//                            break;
//                        case 4:
//                            break;
//                        case 5:
//                            break;
//                        case 6:
//                            break;
//                        case 7:
//                            break;
//                        case 8:
//                            break;
//                        default:
//                            Console.WriteLine("잘못된 입력입니다.");
//                            break;
//                    }

//                            answer = int.Parse(Console.ReadLine());
//                }
//                else
//                {
//                    Console.WriteLine("잘못된 입력입니다.");
//                }

//            }

//        }

//        static void itemList()
//        {
//            for (int i = 0; i < myitems.Length; i++)
//            {
//                Console.Write(i + 1+")");
//                Console.WriteLine(myitems[i].ToString());
//            }
//        }

//        static void shop()
//        {
//            Console.WriteLine("상점");
//            Console.WriteLine("어서오세요! 무엇을 찾으시나요?");
//            Console.WriteLine();
//            Console.WriteLine("원하시는 행동을 입력해주세요");
//            Console.WriteLine("1. 구매");
//            Console.WriteLine("2. 판매");
//            Console.WriteLine("0. 나가기");
//            int answer = int.Parse(Console.ReadLine());

//            if(answer == 0)
//            {
//                Console.WriteLine("처음으로 돌아갑니다.");
//                Main();
//            }
//            if(answer == 1)
//            {
//                shopBuy();
//            }
//            if(answer == 2)
//            {
//                Console.WriteLine("무엇을 가져오셨나요?");
//            }
//            else
//            {
//                Console.WriteLine("잘못된 입력입니다.");
//            }
//        }

//        static void shopBuy()
//        {
//            Console.WriteLine("편하게 둘러보세요.");
//            Console.WriteLine("1. 연장점검 \t150G \t 세상에서 가장 긴 검.");
//            Console.WriteLine("2. 긴급점검 \t100G \t 딱히 빠르지는 않다.");
//            Console.WriteLine("3. 고블린가죽갑옷 \t50G \t 냄새가 좀 난다.");
//            Console.WriteLine("4. 토끼털슬리퍼 \t200G \t 작게 '토끼공듀'라고 적혀있다.");
//            Console.WriteLine("5. 징크스부적 \t350G \t 불행을 막아주기는 커녕 몰고 온다.");
//            Console.WriteLine("6. 함정카드 \t250G \t 전속 전진.");
//            Console.WriteLine("7. 케이크 \t50G \t 블랙 포레스트 체리 케이크. 거짓말이다.");
//            Console.WriteLine("8. 맹독해골 \t 500G \t 투구다. 팬티 아니다.");
//            Console.WriteLine();
//            Console.WriteLine("0. 나가기");

//            int answer = int.Parse(Console.ReadLine());
//            if (answer >= 1 || answer <= 8)
//            {
//                Console.WriteLine("정말로 구매할까요?");
//                switch (answer)
//                {
//                    case 1:
//                        {
//                            LongSword longSword = new LongSword();
//                            longSword.itemName = "연장점검";
//                            longSword.itemDesc = "세상에서 가장 긴 검";
//                            longSword.itemPrice = "150G";
//                            longSword.StatusMSG();
//                        }
//                        break;
//                    case 2:
//                        {

//                        }
//                        break;
//                    case 3:
//                        break;
//                    case 4:
//                        break;
//                    case 5:
//                        break;
//                    case 6:
//                        break;
//                    case 7:
//                        break;
//                    case 8:
//                        break;
//                    default:
//                        Console.WriteLine("잘못된 입력입니다.");
//                        break;
//                }
//                Console.WriteLine("1.구매");
//                Console.WriteLine("0.되돌아가기");

//                answer = int.Parse(Console.ReadLine());

//                while (answer == 0 || answer == 1)
//                {
//                    if (answer == 1)
//                    {
//                        Console.WriteLine("감사합니다.");
//                        break; 
//                    }
//                    if (answer == 0)
//                    {
//                        shopBuy();
//                        break;
//                    }
//                    else
//                    {
//                        answer = int.Parse(Console.ReadLine());
//                    }
//                }

//            }
//            if (answer == 0)
//            {
//                Console.WriteLine("처음으로 돌아갑니다.");
//                Main();
//            }
//            else
//            {
//                Console.WriteLine("잘못된 입력입니다.");
//                answer = int.Parse(Console.ReadLine());
//            }
//        }

//    }
//}
