public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        //I changed the else to else if and added these paramenters so there will be no duplicate values
        else if (value > Data) {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2

        //will always return true because value is data
        if (value == Data){
            return true;
        }

        //This part took me a while and was a little confusing because I forget the syntax for logic in c# but after getting
        //some research I figured it out
        else if (value < Data){
            return Left != null && Left.Contains(value);

        }

        //I modeled this one after the same thing I did for the left side
        else{
            return Right != null && Right.Contains(value);
        }

        //return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        return 0; // Replace this line with the correct return statement(s)
    }
}