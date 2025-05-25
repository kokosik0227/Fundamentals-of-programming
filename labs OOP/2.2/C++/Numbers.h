#ifndef NUMBERS_H
#define NUMBERS_H

#include "Strings.h"
#include <string>

class Numbers : public Strings {
private:
    std::string value;
public:
    Numbers(const std::string& s);
    int length() const override;
    int position(char c) const override;
    std::string getValue() const override;
    void shift() override;
};

#endif 