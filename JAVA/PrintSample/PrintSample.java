public class PrintSample {
    public static void main(String[] args) {
        /* 기본 데이터 타입 */
        int i = 1;
        float f = 1.1f;
        double d = 1.2;
        boolean b = true;
        char c = 'a';
		
        System. out.println(i );
        System. out.println(f );
        System. out.println( d);
        System. out.println(b );
        System. out.println(c );
		
		int sum =0;
		for (int e =1; e<=10000000; e++){
			sum = sum + e;
			System.out.println("1~100d의 합 :" + sum);
		}
    }
}