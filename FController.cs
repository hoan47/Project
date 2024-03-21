﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FController : Form
    {
        public static FController Instance { get; private set; }
        private Form currentFromChild;
        public IdDAO IdDAO { get; private set; }
        public User User { get; private set; }
        public Client Client { get; private set; }
        public List<Hotel> Hotels { get; private set; }
        public AccountDAO AccountDAO { get; private set; }
        public InforDAO InfoDAO { get; private set; }
        public ClientDAO ClientDAO { get; private set; }
        public AddRessDAO AddressDAO { get; private set; }
        public HotelDAO HotelDAO { get; private set; }
        public ServiceDAO ServiceDAO { get; private set; }
        public ImageHotelDAO ImageHotelDAO { get; private set; }
        public RoomDAO RoomDAO { get; private set; }
        public AmenitiesDAO AmenitiesDAO { get; private set; }
        public ImageRoomDAO ImageRoomDAO { get; private set; }


        public FController()
        {
            Instance = this;

            IdDAO = new IdDAO();
            AddressDAO = new AddRessDAO();

            User = new User();

            AccountDAO = new AccountDAO();
            InfoDAO = new InforDAO();
            ClientDAO = new ClientDAO();

            HotelDAO = new HotelDAO();
            ServiceDAO = new ServiceDAO();
            ImageHotelDAO = new ImageHotelDAO();

            RoomDAO = new RoomDAO();
            AmenitiesDAO = new AmenitiesDAO();
            ImageRoomDAO = new ImageRoomDAO();
            InitializeComponent();
            InitializeFLogin();
        }

        private void OpenFormChild(Form formChild)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            currentFromChild = formChild;
            Size = formChild.Size + new Size(15, 40);
            ProcessOpenFormChild(formChild);
        }

        private void OpenFormMessage(Form formChild, Form formParent = null)
        {
            ProcessOpenFormChild(formChild, formParent);
            formChild.Size = formParent != null ? formParent.Size : Size;
        }

        public void ProcessOpenFormChild(Form formChild, Form formParent = null)
        {
            formChild.Location = new Point(0, 0);
            formChild.TopLevel = false;
            if (formParent == null)
            {
                Controls.Add(formChild);
            }
            else
            {
                formParent.Controls.Add(formChild);
            }    
            formChild.BringToFront();
            formChild.Show();
            CenterToScreen();
        }
      
        public void InitializeFLogin()
        {
            OpenFormChild(new FLogin());
        }

        public void InitializeFCreateAccount()
        {
            OpenFormChild(new FCreateAccount());
        }

        public void InitializeFForgetPassword()
        {
            OpenFormChild(new FForgetPassword());
        }

        public void InitializeFMain()
        {
            OpenFormChild(new FMain());
        }
       
        public void MessageSuccess(string tile, string content, Form formParent = null)
        {
            OpenFormMessage(new FCustomMessageBox(tile, content, FCustomMessageBox.EIcon.success), formParent);
        }

        public void MessageWarning(string tile, string content, Form formParent = null)
        {
            OpenFormMessage(new FCustomMessageBox(tile, content, FCustomMessageBox.EIcon.warning), formParent);
        }

        public void MessageError(string tile, string content)
        {
            OpenFormMessage(new FCustomMessageBox(tile, content, FCustomMessageBox.EIcon.error));
        }
    }
}
