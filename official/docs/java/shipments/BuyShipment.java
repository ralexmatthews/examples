import com.easypost.EasyPost;
import java.util.HashMap;

public class BuyShipment {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Shipment shipment = Shipment.retrieve("shp_...");

        HashMap<String, Object> buyMap = new HashMap<String, Object>();
        buyMap.put("rate", shipment.lowestRate());
        buyMap.put("insurance", 249.99);

        shipment.buy(buyMap);

        System.out.println(shipment);
    }
}
