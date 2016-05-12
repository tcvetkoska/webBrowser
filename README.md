####Изработиле
Теодора Цветкоска, Љупче Василев


##Опис на апликацијата
Станува збор за Веб прелистувач кој што е сличен на добро познатите Mozilla Firefox, Google Chrome, Opera ,чијашто намена е општо позната. Се овозможува пристап до www светот, пребарување на различни информации, користење на различни интернет сервиси, посетување на различни веб страни и слично. 
##За  апликацијата	
Со стартување на прелистувачот  (Слика 1) се прикажува почетната страница на прелистувачот (иницијално е наместен  Google).  
![screenshot_3](https://cloud.githubusercontent.com/assets/19307192/15208943/ad95548a-182e-11e6-87b4-4c33a073fd3c.png)
Слика 1: Иницијалниот прозорец на прелистувачот

На сликата може да се забележат неколку копчиња кои што  ги овозможуваат главните функционалности на прелистувачот. Најгоре лево се наоѓаат стандардните копчиња со кои корисникот може да се движи напред назад низ  страниците кои што ги пребарува. Потоа  refresh копчето кое служи за обновување на конекцијата кон дадена веб страница, која веќе претходно сме ја отвориле. Следува копчето кое што со само еден чекор може да не врати  на иницијалната страница,  TextBox поле во кое се наведува Url адресата на веб страната која сакаме да ја посетиме . Доколку некоја статија ја сметаме за важна, претставува нешто што  сакаме повторно да го посетиме без притоа да ја памтиме неговата Url адреса, наслов и слично, како во стандардните прелистувачи, така и во нашиот постои можност за дадена страница да се зачува како омилена и до истата да може да се пристапи во било кој временски период по запамтувањето. Можноста за отворање на повеќе табови истовремено  во кои може да се вчитуваат различни страници е исто така една од можностите на нашиот  прелистувач. 
Со клик на    се во нов таб се отвораат некои дополнителни опции на прелистувачот (слика 2 ). Се овозможува да се  види историјата на пребарување, да се  види листата на омилени страници, се овозможува бришење на истите (бришење на историјата, исто така и бришење на зачуваните омилени страници). Како дополнителна можност се појавува можноста за пребарување без притоа да се зачувува историјата (т.н.  incognito mode). Со штиклирање на контролата (Check Box)  се активира оваа можност. Како можност се појавува и промена на иницијалната страница на прелистувачот.
 
 
######Слика 2: Приказ на табот Setings 





##Претставување на  решението – имплементација

За имплементацијата употребени се 2 класи(History.cs  и Bookmark.cs) и основната – Program.cs  класа, исто така употребени се и 4 форми, т.е. основната форма Form1.cs   која што претставува форма “домаќин”,  во неа се извршуваат повеќето функционалности и преку неа се активираат останатите три форми. Две од нив се едноставни  форми  кои во себе содржат по една ListBox  контрола и служат за приказ  на зачуваните омилени страници и приказ на историјата исто така. Последната форма (слика 3) служи за зачувување на омилена страница, таа се состои од двe TextBox  контроли (URL  и наслов) .
 
######Слика 3: Зачувување на омилени страници

Класата History  е едноставна класа која што се состои од следните три променливи:
public class History
    {
        public String Title { get; set; }
        public String Url { get; set; }
        public String Time { get; set; }

Во нејзиниот состав влегува конструктор, кој прима два аргументи (наслов и Url адреса):

public History(String Title, String Url)
        {
            this.Title = Title;
            this.Url = Url;
            this.Time = String.Format("{0}:{1}",System.DateTime.Now.Hour.ToString(), System.DateTime.Now.Minute.ToString());
        }




Исто така преоптоварен е и методот string To String() со чија помош се прикажуваат информации во формата за приказ  на историјата (слика 4).
 
######Слика 4: Форма за приказ на историјата на пребарување 

public override string ToString()
        {
            return String.Format("Title: {0}, URL: {1}, Time: {2}", Title, Url, Time);
        }
Во продолжение следи класата Bookmark.cs  која што се состои од истите два методи.
    public class Bookmark
    {
        public String Url { get; set; }
        public String Title { get; set; }
        public Bookmark (String Url, String Title)
        {
            this.Url = Url;
            this.Title = Title;
        }
        public override string ToString()
        {
            return String.Format("Title: {0}, URL: {1}",Title,Url);
        }
    }
Во  Form1.cs се наоѓаат сите функционалности на прелистувачот, т.е. тука се имплементирани кодовите за повеќето од копчињата кои во горниот делот за апликацијата се наведени.   
