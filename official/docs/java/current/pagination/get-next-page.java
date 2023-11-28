package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ShipmentCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        // Get the first page of results
        HashMap<String, Object> params = new HashMap<>();
        params.put("page_size", 5);

        ShipmentCollection shipments = client.shipment.all(params);

        // Provide the previous results page to move onto the next page
        ShipmentCollection nextPage = client.shipment.getNextPage(shipments);

        System.out.println(nextPage);
    }
}