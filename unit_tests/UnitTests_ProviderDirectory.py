import pyodbc
import json

server = 'gen-sql.database.windows.net'
database = 'gen-provider-db'
username = 'up_user'
password = 'UPGENSQLSecurity2017!'
driver = '{ODBC Driver 13 for SQL Server}'
ConnectString = 'DRIVER=' + driver + ';PORT=1433;SERVER=' + server + ';PORT=1433;DATABASE=' + database + ';UID=' + username + ';PWD=' + password

def UnitTest_CheckConnection():
    try:
        cnxn = pyodbc.connect(ConnectString,timeout=3)
        print("Connection Achieved.")
        print("")
        return True
    except pyodbc.Error:
        print ("ERROR IN CONNECTION")
    return False


def UnitTest_PrintRows():

    try:
        cnxn = pyodbc.connect(ConnectString,timeout=3)
        cursor = cnxn.cursor()
        cursor.execute("select * from Main_Database_For_Directory")
        for row in cursor:
            print('row = %r' % (row,))
        print("")
        return  True
    except pyodbc.Error:
        print ("ERROR IN CONNECTION")
    return False

def UnitTest_InsertData():
    try:
        cnxn = pyodbc.connect(ConnectString)
        cursor = cnxn.cursor()
        with open('BlueHeartHT_extracted_2017-11-01T07_46_29Z.json', 'r') as infile:
            json_data = json.load(infile)
            orgName = json_data['name']
            orgEmail = json_data['email']
            orgPhone = json_data['phone']
            orgFax = json_data['fax']
            orgAddress = json_data['address']
            orgFacebook = json_data['facebook']
            orgGoogle = json_data['google']
            orgYouTube = json_data['youtube']
            orgInstagram = json_data['instagram']
            orgPinterest = json_data['pinterest']
            orgCharity = json_data['charitynavigator']
            orgLinkedIn = json_data['linkedin']
            orgVimeo = json_data['vimeo']
            orgGuidestar = json_data['guidestar']
            orgTwitter = json_data['twitter']

        cursor.execute("INSERT INTO Main_Database_For_Directory (Organization, PhoneNumber, Email, StreetAddress, County, Country, PostalCode, ServicesOffered, TypeOfOrganization, InformationSource, ApprovedForDirectory, Verified, Fax, Facebook, Google, Youtube, Instagram, Pinterest, CharityNavigator, Linkedin, Vimeo, Guidestar, Twitter, OrgID) values('"+orgName+"','"+orgPhone+"','"+orgEmail+"','"+orgAddress+"','','','','','',0,0,0,'"+orgFax+"','"+orgFacebook+"','"+orgGoogle+"','"+orgYouTube+"','"+orgInstagram+"','"+orgPinterest+"','"+orgCharity+"','"+orgLinkedIn+"','"+orgVimeo+"','"+orgGuidestar+"','"+orgTwitter+"', 0)")

        cnxn.commit()
        print("Data Inserted")
        cursor.execute("select * from Main_Database_For_Directory")
        for row in cursor:
            print('row = %r' % (row,))
        print("")
        return True
    except pyodbc.Error:
        print("ERROR IN INSERTION")
    return false
                       
def UnitTest_DeleteData():
   try:
       cnxn = pyodbc.connect(ConnectString)
       cursor = cnxn.cursor()
       with open('BeautyFrmAshes_extracted_2017-11-01T05_43_05Z.json', 'r') as infile:
           json_data = json.load(infile)
           orgName = json_data['name']
           orgEmail = json_data['email']
           orgPhone = json_data['phone']
           orgFax = json_data['fax']
           orgAddress = json_data['address']
           orgFacebook = json_data['facebook']
           orgGoogle = json_data['google']
           orgYouTube = json_data['youtube']
           orgInstagram = json_data['instagram']
           orgPinterest = json_data['pinterest']
           orgCharity = json_data['charitynavigator']
           orgLinkedIn = json_data['linkedin']
           orgVimeo = json_data['vimeo']
           orgGuidestar = json_data['guidestar']
           orgTwitter = json_data['twitter']

       cursor.execute("DELETE from Main_Database_For_Directory where PhoneNumber = '"+orgPhone+"'")
       cnxn.commit()
       print("Data Deleted")
       cursor.execute("select * from Main_Database_For_Directory")
       for row in cursor:
           print('row = %r' % (row,))
       print("")
       return True
   except pyodbc.Error:
       print("ERROR IN DELETION)")
   return False

def UnitTest_OrgType():
    try:
        cnxn = pyodbc.connect(ConnectString)
        cursor = cnxn.cursor()
        cursor.execute("SELECT Organization, OrgType from Main_Database_For_Directory")
        for row in cursor:
            print('row = %r' % (row,))
        print("")
        return True
    except pyodbc.Error:
        print ("ERROR IN CONNECTION")
        return False

def UnitTest_Services():
    try:
        cnxn = pyodbc.connect(ConnectString)
        cursor = cnxn.cursor()
        cursor.execute("SELECT Organization, Services from Main_Database_For_Directory")
        for row in cursor:
            print('row = %r' % (row,))
        print("")
        return True
    except pyodbc.Error:
        print ("ERROR IN CONNECTION")
        return False

                       
#UnitTest_CheckConnection()
#UnitTest_PrintRows()
UnitTest_DeleteData()
#UnitTest_InsertData()
#UnitTest_OrgType()
#UnitTest_Services()

