#include "String.h"
#include <sstream>
#include <cctype>

String::String(const std::string& s) : value(s) {}

std::string String::GetFirstChars() const {
    if (value.empty()) {
        return "";
    }
    std::string result;
    std::istringstream iss(value);
    std::string word;
    while (iss >> word) {
        if (!word.empty()) {
            result += word[0];
        }
    }
    return result;
}

std::string String::GetValue() const {
    return value;
}

void String::UppercaseFirstLetters() {
    if (value.empty()) return;
    bool newWord = true;
    for (char& c : value) {
        if (std::isspace(static_cast<unsigned char>(c))) {
            newWord = true;
        }
        else {
            if (newWord && std::isalpha(static_cast<unsigned char>(c))) {
                c = std::toupper(static_cast<unsigned char>(c));
            }
            newWord = false;
        }
    }
}