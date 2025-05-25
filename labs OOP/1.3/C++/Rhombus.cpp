#include "Rhombus.h"
#include <cmath>
#include <stdexcept>


Rhombus::Rhombus() : x1(0.0), y1(0.0), x2(1.0), y2(1.0) {}


Rhombus::Rhombus(double x1, double y1, double x2, double y2) : x1(x1), y1(y1), x2(x2), y2(y2) {}


Rhombus::Rhombus(const Rhombus& other) : x1(other.x1), y1(other.y1), x2(other.x2), y2(other.y2) {}


double Rhombus::calculateArea() const {
    return std::abs((x2 - x1) * (y2 - y1));
}


double Rhombus::calculatePerimeter() const {
    double side = std::sqrt(std::pow(x2 - x1, 2) + std::pow(y2 - y1, 2)) / std::sqrt(2);
    return 4 * side;
}


std::vector<double> Rhombus::getCoordinates() const {
    return { x1, y1, x2, y2 };
}


Rhombus Rhombus::operator*(double scalar) const {
    double new_x1 = x1 * scalar;
    double new_y1 = y1 * scalar;
    double new_x2 = x2 * scalar;
    double new_y2 = y2 * scalar;

    if (scalar < 0)
    {
        return Rhombus(new_x2, new_y2, new_x1, new_y1);
    }

    return Rhombus(new_x1, new_y1, new_x2, new_y2);
}


Rhombus& Rhombus::operator=(const Rhombus& other) {
    if (this != &other) {
        x1 = other.x1;
        y1 = other.y1;
        x2 = other.x2;
        y2 = other.y2;
    }
    return *this;
}

Rhombus Rhombus::add(const Rhombus& other) const {
    return Rhombus(x1 + other.x1, y1 + other.y1, x2 + other.x2, y2 + other.y2);
}


Rhombus Rhombus::subtract(const std::vector<Rhombus>& rhombuses) {
    if (rhombuses.empty()) {
        throw std::invalid_argument("Vector of rhombuses is empty");
    }

    Rhombus result = rhombuses[0];
    for (size_t i = 1; i < rhombuses.size(); ++i) {
        result = Rhombus(result.x1 - rhombuses[i].x1, result.y1 - rhombuses[i].y1,
            result.x2 - rhombuses[i].x2, result.y2 - rhombuses[i].y2);
    }
    return result;
}