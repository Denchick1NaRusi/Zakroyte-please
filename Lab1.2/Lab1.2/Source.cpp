#include <stdio.h>
#include <iostream>
#include <limits>
using namespace std;
int main()
{
	setlocale(0, "Rus");
	int i;
	cout << "��� ����� �����������: " << endl;
	cout << "����� ����� " << sizeof(int) << " bytes" << endl;
	cout << "���������� ����� ����� ��� " << INT_MAX << endl;
	cout << "���������� ����� ����� " << INT_MIN << endl;
	cout << "integers__64 are " << sizeof(__int64) << " bytes" << endl;
	cout << "���������� ����� ����� " << _I64_MAX << endl;
	cout << "���������� ����� ����� " << _I64_MIN << endl;
	cout << "������� ������������� �������� " << endl;
	cin >> i;
	cout << endl << "�� ����� ��������� ��������: " << endl;
	cout << "����� �����: " << i << endl;
	// cout << "Integer Overflow: " << INT_MAX + 1 << endl;
	system("PAUSE");
}