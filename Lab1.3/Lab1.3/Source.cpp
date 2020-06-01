#include <iostream>
#include <limits>
using namespace std;
int main()
{
	int i;
	int j;
	int result;
	cout << "For this compiler: " << endl;
	cout << "largest integer is " << INT_MAX << endl;
	cout << "smallest integer is " << INT_MIN << endl;
	cout << "Input two integer values " << endl;
	cin >> i >> j;
	cout << endl << "You entered the following values: " << endl;
	cout << "integer: " << i << " " << j << endl;
	result = i * 10;
	cout << "Your number " << result << endl;
	result = i + j;
	cout << "The sum of your numbers is " << result << endl;
	result = i * j;
	cout << "The product of your numbers is " << result << endl;
	system("PAUSE");
}