//Объявление переменных разных типов: string, int,double, bool
string fullName = "Кристина Шаповалова";
string group = "ИСП253";
string specialty = "09.02.07";
int course = 2;
int weeksLeft = 16;
double score1 = 5.0;
double score2 = 4.0;
double score3 = 4.0;

//Константа: минимальный средний балл для получения стипендии
const double minScoreForScholarship = 4.0;

//Арифметический расчёт: вычисляем средний балл за 3 работы
double averageScore = (score1 + score2 + score3) / 3.0;

bool isScholLarshipEligible = averageScore >= minScoreForScholarship;

Console.WriteLine("ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА");
Console.WriteLine("=========================");
Console.WriteLine($"ФИО: {fullName}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Курс: {course}");
Console.WriteLine($"Специальность: {specialty}");

Console.WriteLine();
Console.WriteLine($"Стипендия положена (>= {minScoreForScholarship:F1}): {isScholLarshipEligible}");

Console.WriteLine();
Console.WriteLine($"Учебных дней осталось в семестре: {weeksLeft}");
Console.WriteLine("==========================");
