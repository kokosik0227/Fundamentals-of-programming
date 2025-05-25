#include <iostream>
#include "Rhombus.h"
#include <vector>
#include <iomanip>


void printRhombusInfo(const std::string& name, const Rhombus& rhombus) {
    std::vector<double> coords = rhombus.getCoordinates();
    std::cout << name << " coordinates: (" << coords[0] << ", " << coords[1] << "), ("
        << coords[2] << ", " << coords[3] << ")" << std::endl;
    std::cout << name << " area: " << std::fixed << std::setprecision(2) << rhombus.calculateArea() << std::endl;
    std::cout << name << " perimeter: " << std::fixed << std::setprecision(2) << rhombus.calculatePerimeter()
        << std::endl;
    std::cout << "-------------------------" << std::endl;
}

int main() {

    Rhombus P1;
    Rhombus P2(1.0, 2.0, 4.0);
    Rhombus P3(2.0, 1.0, 5.0, 4.0);

    std::cout << "Initial values:" << std::endl;
    printRhombusInfo("P1", P1);
    printRhombusInfo("P2", P2);
    printRhombusInfo("P3", P3);


    P3 = P3 * 2.0;
    std::cout << "P3 multiplied by 2:" << std::endl;
    printRhombusInfo("P3", P3);


    P1 = P3;
    P1.subtract({ P2 });

    std::cout << "P3 - P2, result in P1:" << std::endl;
    printRhombusInfo("P1", P1);
    printRhombusInfo("P2", P2);
    printRhombusInfo("P3", P3);


    return 0;
}