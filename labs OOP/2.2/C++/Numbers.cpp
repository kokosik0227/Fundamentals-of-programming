#include "Numbers.h"

Numbers::Numbers(const std::string& s) : value(s) {}

int Numbers::length() const {
    return static_cast<int>(value.length());
}

int Numbers::position(char c) const {
    size_t pos = value.find(c);
    return (pos != std::string::npos) ? static_cast<int>(pos) : -1;
}

std::string Numbers::getValue() const {
    return value;
}

void Numbers::shift() {
    if (!value.empty()) {
        char last = value.back();
        value = std::string(1, last) + value.substr(0, value.length() - 1);
    }
}