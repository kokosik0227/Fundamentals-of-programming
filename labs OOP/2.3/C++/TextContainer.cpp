#include "TextContainer.h"
#include "String.h"

void TextContainer::AddString(const std::string& s) {
    texts.push_back(std::make_unique<String>(s));
}

void TextContainer::DeleteString(size_t index) {
    if (index < texts.size()) {
        texts.erase(texts.begin() + index);
    }
}

void TextContainer::ClearText() {
    texts.clear();
}

void TextContainer::UppercaseFirstLetters() {
    for (auto& text : texts) {
        text->UppercaseFirstLetters();
    }
}

std::string TextContainer::GetKey(const std::string& s) const {
    String temp(s);
    return temp.GetFirstChars();
}

size_t TextContainer::GetCountOfLength(size_t len) const {
    size_t count = 0;
    for (const auto& text : texts) {
        if (text->GetValue().length() == len) {
            ++count;
        }
    }
    return count;
}

const std::vector<std::unique_ptr<Text>>& TextContainer::GetTexts() const {
    return texts;
}