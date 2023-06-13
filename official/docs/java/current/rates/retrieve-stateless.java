package rates;

import java.util.HashMap;
import java.util.List;

import com.easypost.exception.EasyPostException;
import com.easypost.model.StatelessRate;
import com.easypost.model.Shipment;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> toAddressMap = new HashMap<String, Object>();
        toAddressMap.put("name", "Dr. Steve Brule");
        toAddressMap.put("street1", "179 N Harbor Dr");
        toAddressMap.put("city", "Redondo Beach");
        toAddressMap.put("state", "CA");
        toAddressMap.put("country", "US");
        toAddressMap.put("phone", "8573875756");
        toAddressMap.put("email", "dr_steve_brule@gmail.com");
        toAddressMap.put("zip", "90277");

        HashMap<String, Object> fromAddressMap = new HashMap<String, Object>();
        fromAddressMap.put("name", "EasyPost");
        fromAddressMap.put("street1", "417 Montgomery Street");
        fromAddressMap.put("street2", "5th Floor");
        fromAddressMap.put("city", "San Francisco");
        fromAddressMap.put("state", "CA");
        fromAddressMap.put("zip", "94104");
        fromAddressMap.put("country", "US");
        fromAddressMap.put("phone", "4153334445");
        fromAddressMap.put("email", "support@easypost.com");

        HashMap<String, Object> parcelMap = new HashMap<String, Object>();
        parcelMap.put("length", 20.2);
        parcelMap.put("width", 10.9);
        parcelMap.put("height", 5);
        parcelMap.put("weight", 65.9);

        HashMap<String, Object> shipmentDetails = new HashMap<String, Object>();
        shipmentDetails.put("to_address", toAddressMap);
        shipmentDetails.put("from_address", fromAddressMap);
        shipmentDetails.put("parcel", parcelMap);

        List<StatelessRate> rates = client.betaRate.retrieveStatelessRates(shipmentDetails);

        System.out.println(rates);
    }
}
