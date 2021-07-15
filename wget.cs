using System;
using System.IO;
using System.Net;
using System.Web;
using System.Windows.Forms;

public class Program
{
	public static void Main(string[] args)
	{
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;	
	
		string[] param = Environment.GetCommandLineArgs();
		if (param.Length > 1)
		{
			Console.WriteLine( string.Format("������ : {0}", param[1]) );
			Console.WriteLine(string.Format("������ : {0}", args[0]));
		}
		else
		{
			MessageBox.Show("�_�E�����[�h���� URL �������Ɏw�肵�ĉ�����");
			Environment.Exit(0);
		}

		string localFileName = Path.GetFileName(args[0]);
		Console.WriteLine(string.Format("�t�@�C���� : {0}", localFileName));

		using( WebClient wc = new WebClient() ) {
			wc.DownloadFile( args[0], localFileName );
		}

		// *******************************************
		// -ReferencedAssemblies �̕����e�X�g�p
		// *******************************************
		string percent_encoding = HttpUtility.UrlEncode(args[0]);
		Console.WriteLine( percent_encoding );

		MessageBox.Show("�������I�����܂���");

	}
}
