import com.easypost.EasyPost;
import java.util.HashMap;

public class UpdateUser {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("recharge_threshold", "50.00");

        User user = User.retrieveMe();

        user.update(params);

        System.out.println(user);
    }
}
