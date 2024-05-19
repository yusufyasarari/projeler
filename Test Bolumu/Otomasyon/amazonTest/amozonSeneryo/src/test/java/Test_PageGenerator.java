import base.BaseTest;
import org.testng.annotations.Test;

public class Test_PageGenerator extends BaseTest {
    @Test
    public void Test1() throws InterruptedException {
        page.cerezler();
    }

    @Test
    public void Test2() throws InterruptedException {
        page.aramayaz();
    }

    @Test
    public void Test3() throws InterruptedException {
        page.uruneGit();
    }

    @Test
    public void Test4() throws InterruptedException {
        page.sepeteEkle();
    }
    @Test
    public void Test5() throws InterruptedException {
        page.sepeteGit();
    }

    @Test
    public void Test6() throws InterruptedException {
        page.sepetKontrol();
    }
}
