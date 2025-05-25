#include "Numbers.h"
#include "Lowercase.h"
#include <iostream>

int main() {
    Numbers num("2007");
    Lowercase low("nike");

    Strings* str1 = &num;
    Strings* str2 = &low;

    std::cout << "Initial value of num: " << str1->getValue() << std::endl;
    str1->shift();
    std::cout << "After shift in num: " << str1->getValue() << std::endl;

    std::cout << "Initial value of low: " << str2->getValue() << std::endl;
    str2->shift();
    std::cout << "After shift in low: " << str2->getValue() << std::endl;

    return 0;
}