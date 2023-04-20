public class Ball {
    private double size;
    private Color color;
    private int numberThrown;

    public Ball(double size, Color color){
        this.size = size;
        this.color = color;
        numberThrown = 0;
    }

    public double getSize(){
        return size;
    }

    public Color getColor(){
        return color;
    }

    public int getNumberThrown(){
        return numberThrown;
    }

    public void setSize(float size){
        this.size = size;
    }

    public void setColor(Color color){
        this.color = color;
    }

    public void throwBall(){
        numberThrown++;
    }

    public void popBall(){
        numberThrown = 0;
    }

    //get number throw
    public int getNumberThrow(){
        return numberThrown;
    }
}