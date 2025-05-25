#ifndef TEXTCONTAINER_H
#define TEXTCONTAINER_H

#include "Text.h"
#include <vector>
#include <memory>
#include <string>

class TextContainer {
private:
    std::vector<std::unique_ptr<Text>> texts;
public:
    void AddString(const std::string& s);
    void DeleteString(size_t index);
    void ClearText();
    void UppercaseFirstLetters();
    std::string GetKey(const std::string& s) const;
    size_t GetCountOfLength(size_t len) const;
    const std::vector<std::unique_ptr<Text>>& GetTexts() const;
};

#endif