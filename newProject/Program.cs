using System.ComponentModel.Design;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;

namespace newProject
{


    public class Items()
    {

        public int Id;
        public string Name;
        public string Desc;
        public int Price;
        public int Atk;
        public int Def;
        public int HP;
        public bool isEquip;



        public Items(int id, string name, string desc, int price, int atk, int def, int hp, bool isEquip) : this()
        {
            Id = id;
            Name = name;
            Desc = desc;
            Price = price;
            Atk = atk;
            Def = def;
            HP = hp;
            isEquip = isEquip;
        }




    }
    public class Player
    {
        public int Level;
        public string Name;
        public string Job;
        public int Atk;
        public int Def;
        public int HP;
        public int Gold;


        public Player(int level, string name, string job, int atk, int def, int hp, int gold)
        {
            Level = level;
            Name = name;
            Job = job;
            Atk = atk;
            Def = def;
            HP = hp;
            Gold = gold;


        }




    }
    class Program()
    {

        static private  Items longSword = new Items(1, "연장점검", "세상에서 가장 긴 검.", 150, 120, 0, 0,false);
        static public Items quickSword = new Items(2, "긴급점검", "딱히 빠르지는 않다.", 100, 80, 0, 0,false);
        static public Items goblinHide = new Items(3, "고블린가죽갑옷", "냄새가 좀 난다.", 50, 0, 15, 20,false);
        static public Items rabbitFurSleeper = new Items(4, "토끼털슬리퍼", "작게'토끼공듀'라고 적혀있다.", 200, 10, 0, 10,false);
        static public Items jinxCharm = new Items(5, "징크스부적", "불행을 막아주기는 커녕 몰고온다.", 350, 50, -30, 0,false);
        static public Items trapCard = new Items(6, "함정카드", "전속전진", 250, 5, 20, 0,false);
        static public Items cake = new Items(7, "케이크", "블랙포레스트 체리 케이크. 거짓말이다.", 50, 0, 0, 100,false);
        static public Items poisonSkul = new Items(8, "맹독해골", "투구다. 팬티가 아니다.", 500, 0, 20, 60,false);

        static Player player = new Player(1, "까냥꾼", "전사", 10, 5, 100, 1500);




        static void Main(string[] args)
        {
            List<Items> list = new List<Items>();
            list.Add(longSword);
            list.Add(quickSword);
            list.Add(goblinHide);
            list.Add(rabbitFurSleeper);
            list.Add(jinxCharm);
            list.Add(trapCard);
            list.Add(cake);
            list.Add(poisonSkul);

            List<Items> haveItem = new List<Items>();

            List<Items> equipItem = new List<Items>();


            Start();


            void Start()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                    Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                    Console.WriteLine();
                    Console.WriteLine("1.상태보기");
                    Console.WriteLine("2.인벤토리");
                    Console.WriteLine("3.상점");
                    Console.WriteLine();
                    Console.Write("원하시는 행동을 입력해주세요 >>");

                    int input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case 1: Status();
                            break;
                        case 2: Inventory();
                            break;
                        case 3: Shop();
                            break;
                        default: Error();
                            Start();
                            break;
                    }


                }
            }
            

            void Status()
            {

                Console.Clear();
                Console.WriteLine("상태 보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");

                Console.WriteLine("레벨 : " + player.Level);
                Console.WriteLine(player.Name + "(" + player.Job + ")");
                Console.WriteLine("공격력 : " + player.Atk);
                Console.WriteLine("방어력 : " + player.Def);
                Console.WriteLine("체력 : " + player.HP);
                Console.WriteLine("소지골드 : " + player.Gold + "G");

                Console.WriteLine("0.뒤로가기");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        Start();
                        break;
                    default:
                        Error();
                        Status();
                        break;
                }

            }

            void Inventory()
            {



                Console.Clear();
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine("장착하고 싶은 아이템을 선택하세요.");

                for (int i = 0; i < haveItem.Count; i++)
                {
                    Console.WriteLine($"{haveItem[i].Id}.{haveItem[i].Name} \t{haveItem[i].Atk}/{haveItem[i].Def}/{haveItem[i].HP}  \t {haveItem[i].Desc}");
                    Console.WriteLine();
                }
                for (int j = 0; j < equipItem.Count; j++)
                {
                    Console.WriteLine($"{equipItem[j].Id}.[E]{equipItem[j].Name} \t{equipItem[j].Atk}/{equipItem[j].Def}/{equipItem[j].HP}  \t {equipItem[j].Desc}");
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("0.뒤로가기");

                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    Start();
                }
                if (input == 1 && haveItem.Any(e => e.Id == 1))
                {
                    if (longSword.isEquip = false)
                    {
                        haveItem.Remove(longSword);
                        equipItem.Add(longSword);
                        longSword.isEquip = true;
                        Inventory();
                    }
                    else if (longSword.isEquip = true)
                    {
                        equipItem.Remove(longSword);
                        haveItem.Add(longSword);
                        longSword.isEquip = false;
                        Inventory();
                    }
                }
                if (input == 2 && haveItem.Any(e => e.Id == 2))
                {
                    if (quickSword.isEquip = false)
                    {
                        haveItem.Remove(quickSword);
                        equipItem.Add(quickSword);
                        quickSword.isEquip = true;
                        Inventory();
                    }
                    else
                    {
                        equipItem.Remove(quickSword);
                        haveItem.Add(quickSword);
                        quickSword.isEquip = false;
                        Inventory();
                    }
                }
                if (input == 3 && haveItem.Any(e => e.Id == 3))
                {
                    if (goblinHide.isEquip = false)
                    {
                        haveItem.Remove(goblinHide);
                        equipItem.Add(goblinHide);
                        goblinHide.isEquip = true;
                        Inventory();
                    }
                    else
                    {
                        equipItem.Remove(goblinHide);
                        haveItem.Add(goblinHide);
                        goblinHide.isEquip = false;
                        Inventory();
                    }
                }
                if (input == 4 && haveItem.Any(e => e.Id == 4))
                {
                    if (rabbitFurSleeper.isEquip = false)
                    {
                        haveItem.Remove(rabbitFurSleeper);
                        equipItem.Add(rabbitFurSleeper);
                        rabbitFurSleeper.isEquip = true;
                        Inventory();
                    }
                    else
                    {
                        equipItem.Remove(rabbitFurSleeper);
                        haveItem.Add(rabbitFurSleeper);
                        rabbitFurSleeper.isEquip = false;
                        Inventory();
                    }
                }
                if (input == 5 && haveItem.Any(e => e.Id == 5))
                {
                    if (jinxCharm.isEquip = false)
                    {
                        haveItem.Remove(jinxCharm);
                        equipItem.Add(jinxCharm);
                        jinxCharm.isEquip = true;
                        Inventory();
                    }
                    else
                    {
                        equipItem.Remove(jinxCharm);
                        haveItem.Add(jinxCharm);
                        jinxCharm.isEquip = false;
                        Inventory();
                    }
                }
                if (input == 6 && haveItem.Any(e => e.Id == 6))
                {
                    if (trapCard.isEquip = false)
                    {
                        haveItem.Remove(trapCard);
                        equipItem.Add(trapCard);
                        trapCard.isEquip = true;
                        Inventory();
                    }
                    else
                    {
                        equipItem.Remove(trapCard);
                        haveItem.Add(trapCard);
                        trapCard.isEquip = false;
                        Inventory();
                    }
                }
                if (input == 7 && haveItem.Any(e => e.Id == 7))
                {
                    if (cake.isEquip = false)
                    {
                        haveItem.Remove(cake);
                        equipItem.Add(cake);
                        cake.isEquip = true;
                        Inventory();
                    }
                    else
                    {
                        equipItem.Remove(cake);
                        haveItem.Add(cake);
                        cake.isEquip = false;
                        Inventory();
                    }
                }
                if (input == 8 && haveItem.Any(e => e.Id == 8))
                {
                    if (poisonSkul.isEquip = false)
                    {
                        haveItem.Remove(poisonSkul);
                        equipItem.Add(poisonSkul);
                        poisonSkul.isEquip = true;
                        Inventory();
                    }
                    else
                    {
                        equipItem.Remove(poisonSkul);
                        haveItem.Add(poisonSkul);
                        poisonSkul.isEquip = false;
                        Inventory();
                    }
                }
                else
                {
                    Error();
                    Inventory();
                }
               

            }



            void Shop()
            {
                Console.Clear();
                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine();
                Console.WriteLine("1.구매하기");
                Console.WriteLine("0.뒤로가기");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        Start();
                        break;
                    case "1":
                        Buy();
                        break;
                    default:
                        Error();
                        Shop();
                        break;
                }
            }

            void Error()
            {
                Console.WriteLine("잘못된 입력입니다.");
                Thread.Sleep(800);
            }
            void OutOfMoney()
            {
                Console.WriteLine("골드가 부족합니다.");
                Thread.Sleep(800);
            }

            void Buy()
            {

                Console.Clear();
                Console.WriteLine("무엇이 필요하신가요?");
                Console.WriteLine("소지 골드 : " + player.Gold + "G");
                Console.WriteLine();
                for (int i = 0; i < list.Count; i++)
                {
                   Console.WriteLine($"{list[i].Id}.{list[i].Name} \t{list[i].Price}G  \t {list[i].Desc}");
                   Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("0.뒤로가기");

                int input = int.Parse(Console.ReadLine());


                if (input == 0) Start();
                if (input == 1)
                {
                    if (player.Gold >= longSword.Price)
                    {
                        haveItem.Add(longSword);
                        player.Gold -= longSword.Price;
                        list.Remove(longSword);
                        Buy();
                    }
                    else
                    {
                        OutOfMoney();
                        Buy();
                    }
                }
                if (input == 2)
                {
                    if (player.Gold >= quickSword.Price)
                    {
                        haveItem.Add(quickSword);
                        player.Gold -= quickSword.Price;
                        list.Remove(quickSword);
                        Buy();
                    }
                    else
                    {
                        OutOfMoney();
                        Buy();
                    }
                }
                if (input == 3)
                {
                    if(player.Gold >= goblinHide.Price)
                    {
                        haveItem.Add(goblinHide);
                        player.Gold -= goblinHide.Price;
                        list.Remove(goblinHide);
                        Buy();
                    }
                    else
                    {
                        OutOfMoney();
                        Buy();
                    }
                }
                if (input == 4)
                {
                    if (player.Gold >= rabbitFurSleeper.Price)
                    {
                        haveItem.Add(rabbitFurSleeper);
                        player.Gold -= rabbitFurSleeper.Price;
                        list.Remove(rabbitFurSleeper); 
                        Buy();
                    }
                    else
                    {
                        OutOfMoney();
                        Buy();
                    }
                }
                if (input == 5)
                {
                    if(player.Gold >= jinxCharm.Price)
                    {
                        haveItem.Add(jinxCharm);
                        player.Gold -= jinxCharm.Price;
                        list.Remove(jinxCharm);
                        Buy() ;
                    }
                    else
                    {
                        OutOfMoney();
                        Buy();
                    }
                }
                if (input == 6)
                {
                    if(player.Gold >= trapCard.Price)
                    {
                        haveItem.Add(trapCard);
                        player.Gold -= trapCard.Price;
                        list.Remove(trapCard);
                        Buy();
                    }
                    else
                    {
                        OutOfMoney();
                        Buy();
                    }
                }
                if (input == 7)
                {
                    if (player.Gold >= cake.Price)
                    {
                        haveItem.Add(cake);
                        player.Gold -= cake.Price;
                        list.Remove(cake);
                        Buy();
                    }
                    else
                    {
                        OutOfMoney();
                        Buy();
                    }
                }
                if (input == 8)
                {
                    if(player.Gold >= poisonSkul.Price)
                    {
                        haveItem.Add(poisonSkul);
                        player.Gold -= poisonSkul.Price;
                        list.Remove(poisonSkul);
                        Buy();
                    }
                    else
                    {
                        OutOfMoney();
                        Buy();
                    }
                }
                else
                {
                    Error();
                    Buy();
                }
                  










                }
            }
        }
    }
