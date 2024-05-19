import Base.BaseTest;
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
        page.markaSecimi();
    }

    @Test
    public void Test4() throws InterruptedException {
        page.sirlamaOlcusu();
    }
}



