package convertbinario;

public class ConvertBinario {

    public static void main(String[] args) {

        String binCode = "01000110 01100001 01111010 00100000 01101111 00100000 01001100";
        String [] character = binCode.split(" ");
        byte[] data = new byte[character.length];

        for (int index = 0; index < data.length; index++){
            data[index] = Byte.parseByte(character[index],2);
            System.out.print((char)data[index]);
        }
}
