# 01-04-02-MatchProject
##  MatchProject

Feladatunk olyan program írása, amely két párharcból álló mérkőzés alapján eldönti, hogy melyik a győztes csapat ha van.


Készítsen osztály Result néven, amely konstruktora két paramétert kap, a haza és a vendég csapat által elért gólok számát. Határozza meg a hazai (HomeTeamPoint) és a vendég csapat (GuestTeamPoint) pontjait. A győzelem két pontot ér, a döntetlen egy, a vesztes fél nulla pontot kap.


Határozza meg a gólkülönbséget is a haza csapat szemszögéből (GoalDifference). 


Hozzon létre osztályt Match néven amely konstruktora a hazai és vendég csapat nevét, és az első és második meccs eredményét kapja meg. A második meccsen az játszik otthon, aki a második meccsen idegenbe játszott. Határozza meg ki jut tovább. A Winner tulajdonság adja vissza a győztes csapat nevét, vagy ha nincs győztes csapat a „-„ sztringet. Az a csapat jut tovább aki több pontot ért el. Ha ugyan annyi a pontjaik száma, akkor az jut tovább, amelyik több gólt adott. Ha a gólok száma is megegyezik akkor nincs győztes.


Mintakód és kimenet
```
            Result firstMatch = new Result(2, 1);
            Result secontMach = new Result(3, 1);
            Match match = new Match("FTC", "Szeged", firstMatch, secontMach);
            Console.WriteLine(match.Winner);
```
Kimenet:
```
Szeged
```
