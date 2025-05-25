#ifndef TEXT_H
#define TEXT_H

#include <string>

class Text {
public:
    virtual std::string GetFirstChars() const = 0;
    virtual std::string GetValue() const = 0;
    virtual void UppercaseFirstLetters() = 0;
    virtual ~Text() {}
};

#endif