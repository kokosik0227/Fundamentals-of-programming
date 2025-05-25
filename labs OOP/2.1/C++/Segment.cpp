#include "Segment.h"
#include <cmath>
#include <iostream>

Segment::Segment() : Line() {}

Segment::Segment(double x1, double y1, double x2, double y2)
    : Line(x1, y1, x2, y2) {

}

double Segment::changedlength() const {
    return calculateLength() - 5;
}

void Segment::print() {
    std::cout << "x1: " << getX1() << ", y1: " << getY1() << ", x2: " << getX2() << ", y2: " << getY2() << std::endl;
    std::cout << "Length of segment: " << calculateLength() << std::endl;
    std::cout << "Length of segment changed by 5: " << changedlength() << std::endl;
}