#ifndef STRINGS_H
#define STRINGS_H

#include <string>

class Strings {
public:
    virtual int length() const = 0;
    virtual int position(char c) const = 0;
    virtual std::string getValue() const = 0;
    virtual void shift() = 0;
    virtual ~Strings() {}
};

#endif 