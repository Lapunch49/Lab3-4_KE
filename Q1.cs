using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3_4_KE
{
    public partial class Q1 : Form

    {
        string[] cur_status = null;
        string[] status1 = { "What do you need more?", "sleep", "free time", "communication", "self-expression", "attention", "strong emotions" };
        string[] status2 = { "What do you do on weekends?", "sleep", "do chores", "cook", "read books", "go out with friends", "play sports" };
        string[] status3 = { "If household chores were shared among your family members, which would you choose?", "ironing clothes", "care for pets", "garden", "cooking", "", "" };
        string[] status4 = { "On a first date, what would you prefer?", "go to an amusement park", "go to a modern art exhibit", "", "", "", "" };
        string[] status5 = { "When you're in a competition, is it about ...", "winning", "participating", "", "", "", "" };
        string[] status6 = { "If you need to travel to the other side of the country, what transport will you choose?", "car", "ship", "plane", "", "", "" };
        string[] status7 = { "What is your favorite subject at school?", "physical education", "history", "geography", "life safety", "art", "computer science" };
        string[] status8 = { "The description is more suitable for you ...", "bright", "inventor", "patient", "", "", "" };
        string[] status9 = { "What did you like to do as a child?", "dabble", "play with soft toys", "build a construction set", "", "", "" };
        string[] status10 = { "What natural phenomenon takes your breath away and makes you feel a sense of awe and anxiety?", "hurricane", "tsunami", "volcanic eruption", "avalanche", "", "" };

        string[] res1 = { "Yoga nidra", "Yoga nidra is a practice that is often called \"yogic sleep\". Its essence lies in the gradual relaxation of every part of the body, every muscle, every tense part of the body.\nIf you have insomnia, then first with the help of a simple Yoga Nidra technique, you can simply make up for the lack of energy that appeared from a small amount of sleep. But with regular practice, the vegetative processes in the body will gradually improve, which in the end will lead to the return of the regime and getting rid of insomnia.",
        "1_4","1_1","1_2"};
        string[] res2 = { "Extreme ironing", "The essence of extreme ironing boils down to the fact that it is necessary to take an unusual position, for example, to jump with a parachute, dive under water, climb a monument, go into the impenetrable jungle at night, taking an ironing board and an iron with you. Moreover, during the flight, diving (or whatever else an extreme person will come up with), you need to iron your underwear, while it is important to show imagination, because the methods listed above will not surprise anyone.",
        "2_9","2_4","2_7"};
        string[] res3 = { "Encaustic", "Encaustic is an ancient technique of creating paintings using molten colored wax. Anyone can learn it. All you need is paper, wax pencils and an iron. To make a masterpiece is very simple: the necessary color wax (you can even use two or three colors at once) is put on the warm iron, which then lead the piece of paper, the whole or just the edges, depending on what you want to depict. The effect is beyond all expectations: you can create drawings of incredible beauty this way.",
        "3_5","3_2","3_4"};
        string[] res4 = { "Snail training", "Snails are amazing creatures. A healthy, active snail will be both an unusual pet and a universal favorite, which is interesting to watch not only for children, but also for adults. A snail can be taught certain skills by training. The rules of snail competitions comply with international standards. Everything is quite simple: the clams are placed in the center of the table and released on a whistle. Then everything depends on the snails themselves, which, however, the owners lure with lettuce leaves.",
        "4_3","4_2","4_6"};
        string[] res5 = { "Growing butterflies", "A beautiful and unusual hobby for biologists and romantics. In addition to special knowledge, you will need an insectarium, a humidifier, a thermometer and other devices to make the fluttering beauties feel good. But if everything works out, raising tropical butterflies can be a lucrative part-time job.\nIt is not difficult to grow butterflies from pupae. This is an exciting process that captures both adults and children with equal force.",
        "5_3","5_2","5_5"};
        string[] res6 = { "Tree shaping", "Botanical architecture, pooktre, arbo-architecture, tree shaping - whatever you call shaping trees and shrubs to make them more useful. In fact, the hobby is far from new. It's very similar to traditional, long-standing types of tree care, such as bonsai. But Tree shaping is where the green crown, the most eye-catching part of the tree, is relegated to the back burner. But the trunk becomes the object of intricate manipulation. The main difficulty when working on a living wooden sculpture is that it requires really extraordinary patience.",
        "6_3","6_4","6_2"};
        string[] res7 = { "Carving on fruits and vegetables", "Thousands of years ago, people discovered wood carving and perfected it, gradually expanding the list of materials used - bone, stone, metal... Vegetables and fruits made the list about seven hundred years ago.You won't find any disadvantages in the occupation of culinary carving. All successful figures will serve as a decoration of any table, and the marriage will go into salads. Complex masterpieces will be an element of a festive celebration, and a simple but cute sliced apple will raise the appetite of even the most capricious child.",
        "7_5","7_2","7_4"};
        string[] res8 = { "Bookcrossing", "Bookcrossing can be called one of the ways to beautifully get rid of old books. The idea is this: a person who has read a book, leaves it in some public place (library, cafe, bookstore, subway, etc.). A random passerby picks it up, takes it away to read, and in return loses it somewhere else. You can track the movement of books on the project website. Its mission is to promote reading and respect for nature.",
        "8_3","8_1","8_4"};
        string[] res9 = { "Postcrossing", "Postcrossing is a global project, the essence of which is the exchange of paper postcards. The system gives you a random address, you send a postcard to a person, and you receive it from someone else (one of the schemes). As of 2017, over 676 thousand people from all over the world have been registered on the official postcrossing website. People have exchanged more than 40 million postcards. Postcrossing is very popular in Russia and Belarus, because it is romantic and helps to find new friends.",
        "9_3","9_5","9_6"};
        string[] res10 = { "Zorbing", "Zorbing is one of the new types of extreme sports, which consists in lowering a person down the mountain in an inflatable transparent balloon, the so-called zorb.Inside the zorb there are fasteners for fixing the zorbonaut, they resemble climbing equipment and are straps supporting the person by the shoulders, hips and waist, as well as loops for arms and legs. Up to two people can be in a zorbium at a time. Before the descent, each participant undergoes a mandatory briefing on how to behave inside the zorb.",
        "10_3","10_1","10_2"};
        string[] res11 = { "Rafting", "In order to understand what rafting is, you need to imagine a stormy river in front of your eyes, carrying its waters along the banks with dizzying speed, feel the thirst for adventure and the desire to get joy from overcoming obstacles that arise in the way of the river flow. It may seem that such an extreme is available only to trained professionals and a beginner has no place in it — but this is not quite true. Everyone can get an adrenaline rush under the guidance of an experienced instructor.",
        "11_3","11_1","11_2"};
        string[] res12 = { "Flying in an air tube", "Flying in an air tube allows you to experience the sensations of free fall relatively safely. The human body is kept on the surface due to the powerful airflow. An amazing attraction gives you the opportunity to feel like a bird and remember childhood dreams during which you could fly over the ground.",
        "12_1","12_3","12_4"};
        string[] res13 = { "Capoeira", "This is a Brazilian martial art that includes elements of dance, acrobatics and psychological play. This hobby will not only help to keep the body in excellent shape, but also teach you to understand people perfectly — to anticipate the subsequent actions of others, to understand by the face what they are thinking about, it is easy to \"read\" their gestures. Rhythmic smooth movements are replaced in an instant by sharp turns, the most difficult jumps and non-contact blows.",
        "13_4","13_2","13_5"};
        string[] res14 = { "Historical reconstructions", "Do you want to feel like a brave Roman legionary or a Russian vigilante fighting for the prince? Immerse yourself in the wonderful world of historical reconstruction. It's both a science and an art form. Some reconstruct ancient techniques and restore armor, while others put on shows. In order to recreate everything authentically, you need deep knowledge and patience. The historical reconstruction has many fans, clubs are created and various festivals are held.",
        "14_3","14_2","14_1"};
        string[] res15 = { "Geocaching", "Geocaching - treasure hunting. This is an international tourist game, the essence of which is to find a treasure. Some players make geocaches, and others use GPS to search for them. For almost twenty years of history the game has gained millions of fans. The advantage is that this hobby can be done not alone, but with the whole family or a group of friends.",
        "15_3","15_5","15_6"};
        string[] res16 = { "Survivalism", "Survivalists are people who intend to survive any emergency, from natural and man-made disasters to epidemics. Whether something like this happens to them or not doesn't matter. It is important to be prepared! Survivalists assemble their emergency suitcase, organize training games and acquire a number of useful skills (first aid, making fire, disinfecting water, etc.).",
        "16_4","16_2","16_5"};
        string[] res17 = { "Kustomizing", "Kastomizing is the remaking of clothing. Kastomizers reshape jeans into skirts, shirts into dresses, and turn mediocre T-shirts into designer ones. A hobby for those who want to always be in style but aren't willing to spend a lot of money on clothes.For men, customizing often takes the form of transforming motorcycles and cars. Custom bikes are real works of art, and their creators are usually literally sick of their hobby.",
        "17_4","17_5","17_6"};
        string[] res18 = { "Drawings with the curves of the paper", "Available paper is used for different types of creativity, but a rather unusual hobby is not familiar to everyone, it is - drawings with the curves of the paper. All you need is a blank sheet of paper and an unlimited flight of fancy. Try it, in the worst case, you'll only ruin the paper. By the degree of pressure on the future bend, the author creates such unusual paintings. The play of light and shadow creates what we actually see.",
        "18_3","18_2","18_5"};
        string[] res19 = { "Painting dirty cars", "For some people, a dirty car is not an excuse to get it cleaned in a hurry. It's an excuse to get their hands on brushes and paint brushes. In fact, road dust, which accumulates on the surface of car windows, is an excellent raw material for painting.They create real pictures with intricate complicated plot lines on glass. Most often it is possible to see still lifes, landscapes, portraits, caricatures or funny humorous sketches on the windows of dirty cars.",
        "19_2","19_1","19_5"};
        string[] res20 = { "Modding", "It is a modern creative hobby, which consists in modifying computers, their components, in order to improve their aesthetic and consumer characteristics, as well as to give them personality. The goals of modding can be absolutely different. Usually, modding computers and accessories carried out to improve the design and improve the performance of the computer, are possible and situations where you want to make it more convenient to use a computer.",
        "20_3","20_1","20_4"};
        string[] res21 = { "Appearing in the background on TV", "British television viewers have noticed a man who looms in the background of reports time and again. With his massive bald head, his corpulent body and his unchanging beige sweater, it soon became impossible not to recognize him whether he was reading a newspaper, talking on the phone or just watching. It turned out that his name was Paul Yarrow, 42 years old, and thanks to his strange hobby he had already been featured in more than a hundred TV news reports.",
        "21_5","21_3","21_4"};
        string[] res22 = { "Toy traveling", "This is a hobby for those who don't have the time or money to travel themselves. The Czech company Toy Traveling has brought the idea of travel toys to life. Do you have a toy that is ready to go on a trip? At ToyVoyagers.com, you can find a temporary home around the world for your toy or you can shelter someone else's toy. The first thing you do is register on the site, get a ToyVoyager ID, create a blog and a page for your toy, and you can pack up your plush friend! You can make a list of what the toy would like to do on the trip.",
        "22_3","22_1","22_15"};
        string[] res23 = { "Card building", "It turns out that decks of playing cards can be used not only for games, tricks and entertainment, but also to create real masterpieces of architectural skill. The first to do this was American Brian Berg, who chose building buildings and complexes out of cards not only as a way to make a living, but more as a hobby. To date, he is the only person in the world who is able to create wonderful creations from playing cards, touring the world.",
        "23_3","23_7","23_5"};
        string[] res24 = { "Volcano surfing", "The hobby has another name - volcano boarding. Traditional surfing, when you have to slide on the waves of the seas and oceans, have become bored and no longer attracts many creative people with an unusual vision of the world. Now surfing on the slopes of volcanoes has become fashionable. They say that the high-speed descents on the volcanic soil can experience incomparable emotions. Fans of this hobby, standing or sitting on a thin plywood or metal board, rush down the slope of the volcano.",
        "24_3","24_1","24_2"};
        

        public Q1()
        {
            InitializeComponent();
            this.Size = new Size(717, 413);
            cur_status = status1;
            panel1.Visible = false;
            rbt0.Visible = false;
        }
        private void change(string[] status)
        {
            lb_question.Text = status[0];

            rbt0.Checked = true;

            rbtn3.Visible = true;
            rbtn4.Visible = true;
            rbtn5.Visible = true;
            rbtn6.Visible = true;

            rbtn1.Text = status[1];
            rbtn2.Text = status[2];
            rbtn3.Text = status[3];
            if (status[3] == "")
            {
                rbtn3.Visible = false;
            }
            rbtn4.Text = status[4];
            if (status[4] == "")
            {
                rbtn4.Visible = false;
            }
            rbtn5.Text = status[5];
            if (status[5] == "")
            {
                rbtn5.Visible = false;
            }
            rbtn6.Text = status[6];
            if (status[6] == "")
            {
                rbtn6.Visible = false;
            }
            cur_status = status;
        }
        private void result(string[] res)
        {
            this.Size = new Size(831, 519);
            panel1.Location = new Point(0,0);
            panel1.Size = new Size(811, 471);
            panel1.Visible = true;
            lb_title.Text = res[0];
            lb_text.Text = res[1];
            pbx1.Image = Image.FromFile("D:\\Учёба\\Инж знаний\\Lab3-4\\Lab3-4_KE\\изображения\\"+ res[2]+".jpg");
            pbx2.Image = Image.FromFile("D:\\Учёба\\Инж знаний\\Lab3-4\\Lab3-4_KE\\изображения\\" + res[3]+ ".jpg");
            pbx3.Image = Image.FromFile("D:\\Учёба\\Инж знаний\\Lab3-4\\Lab3-4_KE\\изображения\\" + res[4] + ".jpg");
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            change(status1);
            panel1.Visible = false;
            this.Size=new Size(717, 413);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (cur_status == status1 || cur_status == status2)
            {
                result(res1);
            }
            else if (cur_status == status3)
            {
                change(status4);
            }
            else if (cur_status == status4)
            {
                result(res2);
            }
            else if (cur_status == status5)
            {
                result(res4);
            }
            else if (cur_status == status6)
            {
                result(res10);
            }
            else if (cur_status == status7)
            {
                result(res13);
            }
            else if (cur_status == status8)
            {
                result(res17);
            }
            else if (cur_status == status9)
            {
                result(res21);
            }
            else if (cur_status == status10)
            {
                result(res12);
            }
        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (cur_status == status1)
            {
                change(status2);
            }
            else if (cur_status == status2)
            {
                change(status3);
            }
            else if (cur_status == status3)
            {
                change(status5);
            }
            else if (cur_status == status4)
            {
                result(res3);
            }
            else if (cur_status == status5)
            {
                result(res5);
            }
            else if (cur_status == status6)
            {
                result(res11);
            }
            else if (cur_status == status7)
            {
                result(res14);
            }
            else if (cur_status == status8)
            {
                result(res18);
            }
            else if (cur_status == status9)
            {
                result(res22);
            }
            else if (cur_status == status10)
            {
                result(res11);
            }
        }

        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (cur_status == status1)
            {
                result(res9);
            }
            else if (cur_status == status2)
            {
                result(res7);
            }
            else if (cur_status == status3)
            {
                result(res6);
            }
            else if (cur_status == status6)
            {
                result(res12);
            }
            else if (cur_status == status7)
            {
                result(res15);
            }
            else if (cur_status == status8)
            {
                result(res19);
            }
            else if (cur_status == status9)
            {
                result(res23);
            }
            else if (cur_status == status10)
            {
                result(res24);
            }
        }

        private void rbtn4_CheckedChanged(object sender, EventArgs e)
        {
            if (cur_status == status1)
            {
                change(status7);
            }
            else if (cur_status == status2)
            {
                result(res8);
            }
            else if (cur_status == status3)
            {
                result(res7);
            }
            else if (cur_status == status7)
            {
                result(res16);
            }
            else if (cur_status == status10)
            {
                result(res24);
            }
        }

        private void rbtn5_CheckedChanged(object sender, EventArgs e)
        {
            if (cur_status == status1)
            {
                change(status9);
            }
            else if (cur_status == status2)
            {
                result(res9);
            }
            else if (cur_status == status7)
            {
                change(status8);
            }
        }
        private void rbtn6_CheckedChanged(object sender, EventArgs e)
        {
            if (cur_status == status1)
            {
                change(status10);
            }
            else if (cur_status == status2)
            {
                change(status6);
            }
            else if (cur_status == status7)
            {
                result(res20);
            }
        }

        private void Q1_Load(object sender, EventArgs e)
        {

        }

        private void btn_st_Click(object sender, EventArgs e)
        {
            //panel1.Visible = false;
            //change(status1);
            btn_start_Click(sender, e);
        }

        private void Q1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
