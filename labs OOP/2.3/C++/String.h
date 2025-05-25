#ifndef STRING_H
#define STRING_H

#include "Text.h"
#include <string>

class String : public Text {
private:
    std::string value;
public:
    String(const std::string& s);
    std::string GetFirstChars() const override;
    std::string GetValue() const override;
    void UppercaseFirstLetters() override;
};

#endif