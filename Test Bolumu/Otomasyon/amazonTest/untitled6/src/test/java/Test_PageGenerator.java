import Base.BaseTest;
import org.testng.annotations.Test;

public class Test_PageGenerator extends BaseTest {
    @Test
    public void Test1() throws InterruptedException {
        page.cerezler();

    }

    @Test
    public void Test2() throws InterruptedException {
        page.teslimatNoktasinaGit();
    }

    @Test
    public void Test3() throws InterruptedException {
        page.adresBulma();
    }

    @Test
    public void Test4() throws InterruptedException {
        page.adresDefteri();
    }

    @Test
    public void Test5() throws InterruptedException {
        page.giris();
    }

    @Test
    public void Test6() throws InterruptedException {
        page.onaylama();
    }
}
