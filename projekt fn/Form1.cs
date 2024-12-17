using System;
using System.Windows.Forms;

namespace projekt_fn
{
    public partial class Form1 : Form
    {
        // Kérdések és válaszok tömbje
        private string[] questions = new string[]
        {
    "Melyik évben jelent meg a Fortnite?",
    "Melyik játékmódban kell utolsóként életben maradni?",
    "Hány játékos van egy standard Fortnite Battle Royale mérkőzésen?",
    "Mi a Fortnite hivatalos pénzneme?",
    "Melyik fegyver NEM létezik a Fortnite-ban?",
    "Mi a neve a híres Fortnite táncnak?",
    "Milyen célt szolgálnak a Fortnite-ban a 'Shield Potion'-ök?",
    "Milyen ritkasági szintek vannak a fegyvereknél?",
    "Hogyan nevezzük a térképet szűkítő kört?",
    "Mi a Fortnite fejlesztőjének neve?",
    "Milyen járművek szerepelnek a Fortnite-ban?",
    "Melyik Fortnite esemény során tűnt el a térkép egy fekete lyuk miatt?",
    "Melyik híres zenész tartott koncertet a Fortnite-ban?",
    "Mi a neve a Fortnite első térképének?",
    "Melyik szezonban vezették be a repülőket?",
    "Melyik szezonban jelent meg a 'Tilted Towers' helyszín?",
    "Milyen hatással van a játékosra a 'Slurp Juice'?",
    "Hány játékosból áll egy csapat a Squad módban?",
    "Mi történik, ha egy játékos a Storm Circle-ben marad?",
    "Melyik eszközzel lehet építkezni a Fortnite-ban?",
    "Mi történik, ha elfogy az építőanyag?",
    "Melyik állat szerepelt először Fortnite-ban mint jármű?",
    "Milyen hosszú egy Fortnite szezon átlagosan?",
    "Mi a neve a híres Fortnite versenysorozatnak?",
    "Melyik skint nevezték el a játék egyik leghíresebb streameréről?",
    "Milyen ritkaságú a 'Legendary Scar' fegyver?",
    "Hány különböző fegyvertípus található a játékban?",
    "Melyik híres Marvel karakter szerepelt a Fortnite-ban?",
    "Mi történik, ha egy játékos 'Reboot Card'-ját felszedik?",
    "Hány játékosból áll egy Duo csapat?",
    "Mi a 'Chug Jug' használati ideje?",
    "Mi történik, ha egy játékos 'Impulse Grenade'-et dob?",
    "Melyik eszközt használják a játékban a fegyverek fejlesztésére?",
    "Melyik helyszín NEM volt soha a Fortnite térképén?",
    "Mi a neve a Fortnite Battle Pass-ért kapható tárgyaknak?",
    "Hány szintből áll egy standard Battle Pass?",
    "Mi a 'Zero Build' mód jellemzője?",
    "Melyik szezonban jelentek meg a szörnyek a térképen?",
    "Mi a 'Victory Royale' jelentése?",
    "Melyik fegyver szórja a legnagyobb sebzést közeli harcban?",
    "Melyik Fortnite esemény során omlott össze a térkép egy vulkánkitörés miatt?",
    "Milyen jutalom jár egy játékon belüli kihívás teljesítéséért?",
    "Melyik híres autómárka debütált a Fortnite-ban mint jármű?",
    "Melyik szezonban vezették be a halászatot?",
    "Melyik tárgy teszi a játékost láthatatlanná rövid időre?",
    "Melyik fegyver használ rakétákat?",
    "Melyik tánc animáció vált mémmé a közösségben?",
    "Hány aranyat lehet maximum gyűjteni a játékban?",
    "Melyik szezonban jelentek meg először a tematikus NPC-k?"
        };

        private string[,] answers = new string[,]
        {
    { "2015", "2016", "2017", "2018" },
    { "Creative Mode", "Battle Royale", "Save the World", "Arena" },
    { "50", "75", "100", "150" },
    { "Fortnite Bucks", "Battle Coins", "V-Bucks", "Credits" },
    { "Rocket Launcher", "Lightsaber", "Sniper Rifle", "Bow and Arrow" },
    { "Dab", "Floss", "Take the L", "Orange Justice" },
    { "Sebzést okoznak", "Gyógyítanak", "Páncélt adnak", "Extra gyorsaságot adnak" },
    { "Csak Közönséges", "Ritka, Epikus, Legendás", "Közönséges, Ritka, Epikus, Legendás", "Nincs ritkaság" },
    { "Storm Circle", "Final Circle", "Safe Zone", "No Zone" },
    { "Ubisoft", "Valve", "Epic Games", "Activision" },
    { "Autó", "Repülő", "Helikopter", "Minden fent említett" },
    { "Season X", "Chapter 2", "Chapter 3", "Chapter 1" },
    { "Drake", "Marshmello", "Travis Scott", "Ariana Grande" },
    { "Zero Point", "Original Island", "Battle Island", "Spawn Island" },
    { "Season 2", "Season 4", "Season 7", "Season 10" },
    { "Season 2", "Season 3", "Season 4", "Season 5" },
    { "Sebzést okoz", "Páncélt ad", "Gyógyít", "Mindent tesz egyszerre" },
    { "2", "3", "4", "5" },
    { "Semmi", "Sebződik", "Gyorsabb lesz", "Láthatatlanná válik" },
    { "Kalapács", "Pajzs", "Csákány", "Lángszóró" },
    { "Sebződik", "Kijut", "Épít", "Visszatér a játékba" },
    { "Dinosaur", "Boar", "Wolf", "Shark" },
    { "2 hét", "1 hónap", "3 hónap", "6 hónap" },
    { "FNCS", "Battle Royale Finals", "Victory League", "Fortnite Legends" },
    { "Ninja", "Tfue", "Myth", "Bugha" },
    { "Common", "Rare", "Epic", "Legendary" },
    { "5", "7", "10", "12" },
    { "Thor", "Iron Man", "Deadpool", "Hulk" },
    { "Újraéled", "Sebződik", "Eltűnik", "Nincs hatása" },
    { "2", "3", "4", "5" },
    { "5 másodperc", "10 másodperc", "15 másodperc", "20 másodperc" },
    { "Sebzést okoz", "Ellöki a játékost", "Gyógyít", "Láthatatlanná tesz" },
    { "Upgrade Station", "Workbench", "Repair Kit", "Smith Table" },
    { "Lucky Landing", "Paradise Palms", "Frosty Flights", "Viking Village" },
    { "V-Bucks", "Stars", "Battle Stars", "Coins" },
    { "50", "100", "200", "500" },
    { "Építkezés nélkül játszható", "Nincs lövöldözés", "Csak szóló", "Csak kreatív építés van" },
    { "Season 2", "Season 4", "Season 6", "Season 8" },
    { "Első helyezett", "Top 10", "Top 5", "Utolsó életben maradó" },
    { "Shotgun", "Pistol", "Sniper", "Sword" },
    { "Season 2", "Season 4", "Season 6", "Season 8" },
    { "XP", "V-Bucks", "Battle Stars", "Coins" },
    { "Lamborghini", "Ferrari", "Toyota", "Tesla" },
    { "Chapter 1", "Chapter 2", "Season 3", "Season 5" },
    { "Invisibility Cloak", "Shadow Stone", "Ghost Orb", "Phantom Cube" },
    { "Rocket Launcher", "Sniper", "Flare Gun", "Grenade" },
    { "Floss", "Orange Justice", "Best Mates", "Dab" },
    { "1000", "2000", "3000", "5000" },
    { "Season 2", "Season 4", "Season 5", "Season 6" }
        };

        private int[] correctAnswers = { 2, 2, 2, 3, 1, 1, 2, 2, 0, 2, 3, 1, 2, 1, 2, 2, 1, 2, 1, 2, 0, 0, 1, 2, 0, 0, 3, 2, 2, 0, 3, 1, 0, 1, 2, 3, 0, 2, 3, 3, 1, 1, 1, 3, 2, 0, 0, 2, 1, 2 };

        private int currentQuestion = 0;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeUI(); // UI control setup
            LoadQuestion();
            btnNext.Click += btnNext_Click;
        }

        private void InitializeUI()
        {
            // Ensure the UI controls are set up properly at the start
            lblScore.Text = "Pontszám: 0";
            btnNext.Enabled = true;
        }

        // Kérdés betöltése
        private void LoadQuestion()
        {
            if (currentQuestion < questions.Length)
            {
                lblQuestion.Text = questions[currentQuestion];
                rbtnAnswer1.Text = answers[currentQuestion, 0];
                rbtnAnswer2.Text = answers[currentQuestion, 1];
                rbtnAnswer3.Text = answers[currentQuestion, 2];
                rbtnAnswer4.Text = answers[currentQuestion, 3];

                // Reset radio buttons
                rbtnAnswer1.Checked = false;
                rbtnAnswer2.Checked = false;
                rbtnAnswer3.Checked = false;
                rbtnAnswer4.Checked = false;
            }
        }

        // Következő gomb eseménye
        private void btnNext_Click(object sender, EventArgs e)
        {
            int selectedAnswer = GetSelectedAnswer();

            if (selectedAnswer == 0)
            {
                MessageBox.Show("Kérlek válaszd ki a helyes választ!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Don't move to the next question
            }

            if (selectedAnswer -1 == correctAnswers[currentQuestion])
            {
                score++;
            }

            currentQuestion++;

            if (currentQuestion < questions.Length)
            {
                LoadQuestion();
            }
            else
            {
                MessageBox.Show($"Vége a játéknak! Pontszámod: {score}/{questions.Length}", "Játék vége", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }

            lblScore.Text = $"Pontszám: {score}";
        }

        // Kiválasztott válasz lekérdezése
        private int GetSelectedAnswer()
        {
            if (rbtnAnswer1.Checked) return 1;
            if (rbtnAnswer2.Checked) return 2;
            if (rbtnAnswer3.Checked) return 3;
            if (rbtnAnswer4.Checked) return 4;

            return 0; // Ha nincs kiválasztva válasz
        }
    }
}
