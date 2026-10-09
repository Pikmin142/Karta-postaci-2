Console.WriteLine("Podaj imie Bohatera:");
string Imie = Console.ReadLine()!;
Console.WriteLine("Podaj symbol Bohatera:");
char Symbol = char.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj maksymalne zdrowie:");
int MaksHP = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj aktualne hp:");
int AktualneHP = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj podstawowe obrażenia:");
int PodsObrazenia = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj premię do broni:");
int Premiabroni = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj mnożnik ataku specjalnego: ");
double MnoznikAtaku = double.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj liczbe wykonanych ataków");
int liczbaAtakow = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj liczbe miejsc w plecaku");
int MiejscaWPlecaku = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj liczbe przedmiotów w plecaku");
int PrzedmiotywPlecaku = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj liczbe członków drużyny");
int liczbaCzłonków = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj liczbe znalezionego złota");
int liczbaSkarbu = int.Parse(Console.ReadLine()!);
Console.WriteLine("Czy masz mapę");
bool czyJestMapa = bool.Parse(Console.ReadLine()!);










int zwyklyAtak = PodsObrazenia + Premiabroni;
double atakSpecjalny = PodsObrazenia * MnoznikAtaku;
double laczneObrazenia = liczbaAtakow*zwyklyAtak + atakSpecjalny;
double aktualeHp = AktualneHP;
double maksHp = MaksHP;
double pozostaleZdrowiewProce = (aktualeHp / maksHp) * 100;
bool czZyje = AktualneHP > 0;
bool czyPelneHP = AktualneHP == MaksHP;
int wolneMiejsca = MiejscaWPlecaku - PrzedmiotywPlecaku;
int zlotoNaOsobe = liczbaSkarbu/liczbaCzłonków;
int resztaZłota = liczbaSkarbu%liczbaCzłonków;
bool wolnemiejsceWPlecaku = wolneMiejsca > 0;
bool wymagaHp = aktualeHp > 0 && aktualeHp < MaksHP;
bool Gotowy = czZyje && czyJestMapa;






Console.WriteLine("============Karta Bohatera===========");
Console.WriteLine($"Bohater: {Imie}");
Console.WriteLine("=====================================");
Console.WriteLine($"Zdrowie: {AktualneHP}/{MaksHP} ({pozostaleZdrowiewProce:F2}%): ");
Console.WriteLine($"Zwykły atak: {zwyklyAtak}");
Console.WriteLine($"Premia broni: {zwyklyAtak}");
Console.WriteLine($"Mnożnik Atak specalnego: {MnoznikAtaku:F2}");
Console.WriteLine($"Łączne zadane obrażenia: {laczneObrazenia}:");
Console.WriteLine($"Obrażenia ataku specjalnego: {atakSpecjalny}:");
Console.WriteLine("=====================================");
Console.WriteLine($"Plecak: {PrzedmiotywPlecaku}/{MiejscaWPlecaku}");
Console.WriteLine($"Wolne miejsca: {wolneMiejsca}");
Console.WriteLine($"Złoto: {liczbaSkarbu}");
Console.WriteLine($"Liczba członków w drużynie: {liczbaCzłonków}");
Console.WriteLine($"Złoto dla jednej osoby: {zlotoNaOsobe}");
Console.WriteLine($"Złoto pozostałe w skarbcu: {resztaZłota}");
Console.WriteLine("=====================================");
Console.WriteLine($"Ma mapę: {czyJestMapa}");
Console.WriteLine($"Żyje: {czZyje}");
Console.WriteLine($"Pełne zdrowie: {czyPelneHP}");
Console.WriteLine($"Ma pełne Hp: {wymagaHp}");
Console.WriteLine($"Ma miejsce w plecaku: {wolnemiejsceWPlecaku}");
Console.WriteLine($"Gotowi do wyprawy: {Gotowy}");
Console.WriteLine("=====================================");

