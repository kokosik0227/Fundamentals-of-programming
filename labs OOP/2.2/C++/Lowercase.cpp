#include "Lowercase.h"

Lowercase::Lowercase(const std::string& s) : value(s) {}

int Lowercase::length() const {
    return static_cast<int>(value.length());
}

int Lowercase::position(char c) const {
    size_t pos = value.find(c);
    return (pos != std::string::npos) ? static_cast<int>(pos) : -1;
}

std::string Lowercase::getValue() const {
    return value;
}

void Lowercase::shift() {
    if (!value.empty()) {
        value = value.substr(1) + value.substr(0, 1);
    }
}