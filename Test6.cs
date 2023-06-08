using System;
//傳入多個點的回傳陣列points[]  回傳距離最遠的兩個點
//直角三角形的斜邊公式為x*2+y*2=z^2
public class Test6
{
    public Point[] test(Point[] points)
	{
        int pointCount = points.length;
        //New一個陣列長度 - 1的新陣列 distanceMap
        for (int i = 0; i < pointCount - 1; i++)
        {
            int maxDistance = 0;
            for (int j = 1; 到後面陣列結束）
            {
                //
                int distance = calDistance(points[i], point[j]);
                //比大小 更新maxDistance 
            }
        };

        Point[] ansPoints = new Point[2];
		ansPoints[1] = new Point(1, 7);
		ansPoints[0] = new Point(5, 1);
		return ansPoints;
	}
    private int calDistance(Point p1, Point p2)
    {
        int distance = 0;
		var r = (p1._x - p2._x)(p1._x - p2._x) + (p1._y - p2._y)(p1._y - p2._y);
		distance = Math.Sqrt(r);
        return distance;
    }
}

public class Point
{
	public int _x;
	public int _y;
	public Point(int x, int y)
	{
		_x = x;
		_y = y;
	}
    public int getX()
    {
        return _x();
    }
    public int getY()
    {
        return _y();
    }
	public override bool Equals(object obj)
	{
		var input = obj as Point;
		if(input == null) { 
		return false;
		}
		else
		{
			return (_x == input._x) && (_y == input._y);
		}
	}
}


