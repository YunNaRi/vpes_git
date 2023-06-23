/* $$43564A43$$ WARNING: Do not edit. $$ This file has been instrumented by qualityscroll_cover_jacov 4.0.4-SNAPSHOT (Instrument Date:20230622195157) $$ */public class PrintSample {
    public static transient boolean[] $qualityscroll_cover_coverage_buffer = $qualityscroll_cover_coverage_buffer_init();public static boolean[] $qualityscroll_cover_coverage_buffer_init() {try{if($qualityscroll_cover_coverage_buffer != null){return $qualityscroll_cover_coverage_buffer;}java.lang.Class<?> thisClass = PrintSample.class.getClassLoader().loadClass("com.qualityscroll.cover.runtime.ProbeStore");java.lang.reflect.Method getProbesMethod = thisClass.getMethod("getProbes", long.class, long.class, long.class, java.lang.String.class, int.class);$qualityscroll_cover_coverage_buffer = (boolean[]) getProbesMethod.invoke(null,/* key(tuId + timestamp) */ -5277964048867095948L,/* translation unit id   */ -1041702180469410836L,/* timestamp             */ 1687431117284L,/* source file name      */ "PrintSample.java",/* probe size            */ 4);}catch(java.lang.Exception e){throw new java.lang.RuntimeException(e);}return $qualityscroll_cover_coverage_buffer;}private static boolean $qualityscroll_cover_jacov_probe_f18b2162d35ef3ec(int index) {$qualityscroll_cover_coverage_buffer[index] = true;return true;}public static void main(String[] args) {$qualityscroll_cover_coverage_buffer_init();
        /* 기본 데이터 타입 */
        $qualityscroll_cover_jacov_probe_f18b2162d35ef3ec(0);int i = 1;
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
		$qualityscroll_cover_jacov_probe_f18b2162d35ef3ec(1);for (int e =1; (e<=10000000) ? true : (!$qualityscroll_cover_jacov_probe_f18b2162d35ef3ec(3) && false); e++){
			$qualityscroll_cover_jacov_probe_f18b2162d35ef3ec(2);sum = sum + e;
			System.out.println("1~100d의 합 :" + sum);
		}
    }
}