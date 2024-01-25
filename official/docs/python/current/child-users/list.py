import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

childUsers = client.user.all_children(page_size=5)

print(childUsers)
