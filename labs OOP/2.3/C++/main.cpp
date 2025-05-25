#include "TextContainer.h"
#include "String.h"
#include <iostream>

int main() {
    TextContainer container;


    container.AddString("hello world");
    container.AddString("test case");
    container.AddString("c++ programming");


    std::cout << "Initial strings:" << std::endl;
    size_t index = 0;
    for (const auto& text : container.GetTexts()) {
        std::cout << "String " << index++ << ": " << text->GetValue() << ", Key: " << text->GetFirstChars() << std::endl;
    }


    container.UppercaseFirstLetters();
    std::cout << "\nAfter capitalizing first letters:" << std::endl;
    index = 0;
    for (const auto& text : container.GetTexts()) {
        std::cout << "String " << index++ << ": " << text->GetValue() << ", Key: " << text->GetFirstChars() << std::endl;
    }


    std::string key = container.GetKey("quick fox jump");
    std::cout << "\nKey for 'quick fox jump': " << key << std::endl;


    size_t count = container.GetCountOfLength(10);
    std::cout << "Number of strings with length 10: " << count << std::endl;


    container.DeleteString(1);
    std::cout << "\nAfter deleting string at index 1:" << std::endl;
    index = 0;
    for (const auto& text : container.GetTexts()) {
        std::cout << "String " << index++ << ": " << text->GetValue() << ", Key: " << text->GetFirstChars() << std::endl;
    }


    container.ClearText();
    std::cout << "\nAfter clearing container:" << std::endl;
    std::cout << "Number of strings with length 11: " << container.GetCountOfLength(11) << std::endl;

    return 0;
}