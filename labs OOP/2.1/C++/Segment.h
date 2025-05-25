#include "Line.h"

class Segment : public Line {
public:
	Segment();
	Segment(double x1, double y1, double x2, double y2);
	double changedlength() const;

	void print();
};