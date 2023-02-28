#include <iostream>
#include <cstdlib>
#include <cstring>

using namespace std;

int main()
{
    int magicNumber = 0xF;
    srand(time(NULL));
    int randomNumber = rand() % 1000;
    int address = randomNumber + magicNumber;
    int* ptr = (int*)address;
    *ptr = 0x4C;
    char letter = (char)*ptr;
    cout << letter << endl;

    return 0;
}