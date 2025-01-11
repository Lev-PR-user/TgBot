using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;


using var cts = new CancellationTokenSource();
var bot = new TelegramBotClient("7406423508:AAGkPlTi-DFaFP0B5JJ1PxVfYRSsz-LCL_s", cancellationToken: cts.Token);

int Nam = 1;

var me = await bot.GetMe();
bot.OnMessage += OnMessage;

Console.WriteLine($"@{me.Username} is running... Press Enter to terminate");
Console.ReadLine();
cts.Cancel(); // stop the bot

// метод, который обрабатывает сообщения, полученные ботом:
async Task OnMessage(Message msg, UpdateType type)
{
    string[] ower = { "Застрял в лифте с бабушкой. ", "Переводил бабушку через дорогу.", "Меня родители не отустили гулять. ", "Я сегодня играю в шахматы со своим попугаем"};
    string[] School = { "Застрял в лифте с бабушкой. ", "Переводил бабушку через дорогу.",  "Я перепутал школу/класс.", "Я помогал/а директору найти нашу школу." };
    string[] HomeWork = {   "Извините я дома забыл.", " Её съела моя собака.", "Я жду пока придёт озарение.", "Её украли инопланетяне."};
    string[] Cleaning = { "У меня аллергия на такую работу.", " Я сейчас не могу у меня катка в доте.", "Я не умею." };
    string[] quarrel = { " Мой кот хочет обсудить со мной свои проблемы.", " Извини но у меня безконфликтная диета.", "Я только что окончил курс по избеганию конфликтов, пора применять мои навыки." };
    string[] morning = { "Мой диван очень не хочет меня отпускать.", "Мой кот сказал мне, что мне надо побыть дома.", "За окном сейчас плохая погода, для меня." };
    string[] Late = { "Мой друг поросил проводить его до дома.", "Я помогал бабушке отнести продукты.", "меня задержали дети, прося с ними поиграть." };


    var random = new Random(); // инициализация генератора случайных чисел




    


    if (Nam == 1)
    {
        Console.WriteLine($"Received {type} '{msg.Text}' in {msg.Chat}");
        await bot.SendMessage(msg.Chat, "Привет");
        await bot.SendMessage(msg.Chat, "Как тебя зовут?");
        Nam++;
    }
    else if (Nam == 2)
    {
        string userName = msg.Text;
        await bot.SendMessage(msg.Chat, "Привет " + userName);
        await bot.SendMessage(msg.Chat, "Я бот который поможет тебе отмазаться от каких-либо ситуаций.");
        await bot.SendMessage(msg.Chat, "Например:");
        await bot.SendMessage(msg.Chat, "1. Пришел/а поздно домой."
            + "\n2. Не пойти на прогулку с друьями."
            + "\n3. Уйти от ссоры  с кем-либо."
            + "\n4. Опоздал/а на пару/урок."
            + "\n5. Не сделал домашнее задание."
            + "\n6. Избежать уборки дома."
            + "\n7. Отказаться от утренней пробежки"
            + "\n8. Не пришел/а в колледж/школу"
            + "\n");

        Nam++;
    }



    else if (Nam == 3)
    {
 
     




        switch (msg.Text)
        {


            case "1":

                await bot.SendMessage(msg.Chat, "Вы выбрали 1.");

                string randomLate = Late[random.Next(Late.Length)];
                await bot.SendMessage(msg.Chat, $" {randomLate}");

                break;

            case "2":

                await bot.SendMessage(msg.Chat, "Вы выбрали 2." );

                string randomOwer = ower[random.Next(ower.Length)];
                await bot.SendMessage(msg.Chat, $" {randomOwer}");

                break;

            case "3":

                await bot.SendMessage(msg.Chat, "Вы выбрали 3.");

                string randomquarrel = quarrel[random.Next(quarrel.Length)];
                await bot.SendMessage(msg.Chat, $" {randomquarrel}");

                break;

            case "4":
    
                await bot.SendMessage(msg.Chat, "Вы выбрали 4.");

                string randomSchool = School[random.Next(School.Length)];
                await bot.SendMessage(msg.Chat, $" {randomSchool}");

                break;

            case "5":
               
                await bot.SendMessage(msg.Chat, "Вы выбрали 5.");

                string randomHomework = HomeWork[random.Next(HomeWork.Length)];
                await bot.SendMessage(msg.Chat, $" {randomHomework}");

                break;

            case "6":

                await bot.SendMessage(msg.Chat, "Вы выбрали 6.");

                string randomCleaning = Cleaning[random.Next(Cleaning.Length)];
                await bot.SendMessage(msg.Chat, $" {randomCleaning}");


                break;

            case "7":

                await bot.SendMessage(msg.Chat, "Вы выбрали 7.");

                string randommorning = morning[random.Next(morning.Length)];
                await bot.SendMessage(msg.Chat, $" {randommorning}");

                break;

            case "8":

                await bot.SendMessage(msg.Chat, "Вы выбрали 8.");

                string randomSchool2 = School[random.Next(School.Length)];
                await bot.SendMessage(msg.Chat, $" {randomSchool2}");

                break;

            default:

                await bot.SendMessage(msg.Chat, "Пожалуйста, выберите подходящий вариант (1-8)..");

                return;


        }




    }
}
