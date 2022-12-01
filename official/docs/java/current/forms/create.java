package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;
import com.easypost.service.EasyPostClient;

import java.util.ArrayList;
import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        Shipment shipment = client.shipment.retrieve("shp_...");
        Shipment boughtShipment = client.shipment.buy(shipment.getId(), shipment.lowestRate());

        HashMap<String, Object> titleMap = new HashMap<String, Object>();
        titleMap.put("title", "Square Reader");

        HashMap<String, Object> barcodeMap = new HashMap<String, Object>();
        barcodeMap.put("barcode", "855658003251");

        ArrayList<HashMap<String, Object>> lineItemsMap = new ArrayList<HashMap<String, Object>>();
        lineItemsMap.add(titleMap);
        lineItemsMap.add(barcodeMap);

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("barcode", "RMA12345678900");
        params.put("units", 8);
        params.put("line_items", lineItemsMap);

        Shipment shipmentWithForm = client.shipment.generateForm(boughtShipment.getId(), "return_packing_slip",
                params);

        System.out.println(shipment);
    }
}
