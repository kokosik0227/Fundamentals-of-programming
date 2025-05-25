#ifndef LOWERCASE_H
#define LOWERCASE_H

#include "Strings.h"
#include <string>

class Lowercase : public Strings {
private:
    std::string value;
public:
    Lowercase(const std::string& s);
    int length() const override;
    int position(char c) const override;
    std::string getValue() const override;
    void shift() override;
};

#endif 
