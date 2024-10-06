double x = 3.7;

Console.Write("Введи a = ");
double a = Convert.ToDouble(Console.ReadLine());

// Вычисляем логарифм от абсолютного значения (cos(x) - 5)
double logg = Math.Log(Math.Abs(Math.Cos(x) - 5));

// Вычисляем экспоненту от cos(x)
double expon = Math.Exp(Math.Cos(x));

// Извлекаем корень из (a + x^2 * ln(|cos(x) - 5|))
double sqrtT = Math.Sqrt(a + x * x * logg);


// Делим на экспоненту
double Resultat = sqrtT / expon;

// Выводим результат
Console.WriteLine("Ответ: " + Resultat);

