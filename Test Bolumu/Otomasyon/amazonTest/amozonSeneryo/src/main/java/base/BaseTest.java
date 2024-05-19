package base;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.annotations.AfterTest;
import org.testng.annotations.BeforeTest;


public class BaseTest {
    WebDriver driver;
    public PageGenerator page;

    @BeforeTest
    public void setUp() {
        // WebDriverManager.chromedriver().setup();
        driver = new ChromeDriver();
        driver.get("https://www.amazon.com.tr/");
        driver.manage().window().maximize();

        page = new PageGenerator(driver);
    }

    @AfterTest
    public void tearDown() {
        driver.quit();
    }
}


