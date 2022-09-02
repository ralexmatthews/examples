import com.easypost.EasyPost;
import java.util.HashMap;

public class RetrieveInsuranceList {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        HashMap<String, Object> listParams = new HashMap<>();
        listParams.put("page_size", 5);

        InsuranceCollection insurances = Insurance.all(listParams);

        System.out.println(insurances);
    }
}
