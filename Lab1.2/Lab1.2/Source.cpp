#include <stdio.h>
#include <iostream>
#include <limits>
using namespace std;
int main()
{
	setlocale(0, "Rus");
	int i;
	cout << "Для этого компилятора: " << endl;
	cout << "Целые числа " << sizeof(int) << " bytes" << endl;
	cout << "Наибольшее целое число это " << INT_MAX << endl;
	cout << "Наименьшее целое число " << INT_MIN << endl;
	cout << "integers__64 are " << sizeof(__int64) << " bytes" << endl;
	cout << "наибольшее целое число " << _I64_MAX << endl;
	cout << "наименьшее целое число " << _I64_MIN << endl;
	cout << "Введите целочисленное значение " << endl;
	cin >> i;
	cout << endl << "Вы ввели следующее значение: " << endl;
	cout << "целое число: " << i << endl;
	// cout << "Integer Overflow: " << INT_MAX + 1 << endl;
	system("PAUSE");
}