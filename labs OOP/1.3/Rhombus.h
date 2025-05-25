#ifndef RHOMBUS_H
#define RHOMBUS_H

#include <vector>

class Rhombus {
private:
    double x1, y1, x2, y2;

public:

    Rhombus();
    Rhombus(double x1, double y1, double x2, double y2 = 3);
    Rhombus(const Rhombus& other);


    double calculateArea() const;
    double calculatePerimeter() const;


    std::vector<double> getCoordinates() const;


    Rhombus operator*(double scalar) const;
    static Rhombus subtract(const std::vector<Rhombus>& rhombuses);
    Rhombus& operator=(const Rhombus& other);
    Rhombus add(const Rhombus& other) const;

};

#endif